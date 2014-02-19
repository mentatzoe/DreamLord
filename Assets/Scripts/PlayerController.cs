﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float maxSp = 10f;
	public float run = 10f;
	public int runs = 1;
    public int timer;
    public int score;
    public float climbSpeed = 0.02f;
    public bool playing = false;
    public bool isClimbing;
    public bool isMoveLeft;
    public bool isMoveRight;
    Climbing climbController;
    Climbing leftController;
    Climbing rightController;
	private Animator anim;
	private GameObject c;
	private bool facingRight = true;
	// Use this for initialization
	void Start () {
		c = GameObject.Find ("Main Camera");
        GameObject up = GameObject.Find("Up");
        GameObject left = GameObject.Find("Left");
        GameObject right = GameObject.Find("Right");
        climbController = up.GetComponent<Climbing>();
        leftController = left.GetComponent<Climbing>();
        rightController = right.GetComponent<Climbing>();
        timer = 0;
		anim = this.GetComponent<Animator> ();
	}

	
	// Update is called once per frame
	void Update(){

	}


	void OnTriggerEnter2D(Collider2D coll){
        if (coll.gameObject.tag == "climb")
        {
            playing = true;
            score++;
        }
        else if (coll.gameObject.tag == "hazard")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z);
        }
        else if (coll.gameObject.tag == "helper")
        {
            playing = true;
            score++;
            climbSpeed = climbSpeed * 2;
        }
	}

    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "helper")
        {
            climbSpeed = climbSpeed / 2;
        }
    }
	
	void FixedUpdate () {
		anim.SetBool ("side", false);
       // float move = Input.acceleration.y;
        float move = Input.GetAxis("Horizontal");
        isClimbing = climbController.isClimbing;
        isMoveLeft = leftController.isClimbing;
        isMoveRight = rightController.isClimbing;
        //Debug.Log("Acceleration = " + move);
        if (move < 0 && isMoveLeft && timer > 10)
        {
            //rigidbody2D.velocity = new Vector2 (move*maxSp, rigidbody2D.velocity.y);
            transform.position = new Vector2(transform.position.x - 1.5f, transform.position.y);
            timer = 0;
			anim.SetBool ("side", true);
		//	if (facingRight)
		//		Flip ();
        }
        if (move > 0 && isMoveRight && timer > 10)
        {
            transform.position = new Vector2(transform.position.x + 1.5f, transform.position.y);
            timer = 0;
			anim.SetBool ("side", true);
		//	if (!facingRight)
		//		Flip ();
        }

		//Debug.Log (c.transform.position.y - transform.position.y > -2);
        if (isClimbing && (c.transform.position.y - transform.position.y > -2)) {

			transform.position = new Vector3 (transform.position.x, transform.position.y + climbSpeed);
		}
        timer++;
	}
		

	void OnBecameInvisible () {

		Debug.Log("invisible Win " + runs);

		if (runs == GameManager.TOTAL_RUNS) {
			GameManager.Instance.finishedMiniGame ();
		} else {
			transform.position = new Vector2(0.1635f,-1.6489f);
			rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, 0f);
		}
        Application.LoadLevel("Menu");
	}

	void Flip () {
		Vector2 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
