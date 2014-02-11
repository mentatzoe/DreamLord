using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float maxSp = 10f;
	public float run = 10f;
	public int runs = 1;
    public int timer;
    public bool playing = false;
    public bool isClimbing;
    public bool isMoveLeft;
    public bool isMoveRight;
    Climbing climbController;
    Climbing leftController;
    Climbing rightController;
	// Use this for initialization
	void Start () {
        GameObject up = GameObject.Find("Up");
        GameObject left = GameObject.Find("Left");
        GameObject right = GameObject.Find("Right");
        climbController = up.GetComponent<Climbing>();
        leftController = left.GetComponent<Climbing>();
        rightController = right.GetComponent<Climbing>();
        timer = 0;
	}

	
	// Update is called once per frame
	void Update(){

	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Green") {
			float t = rigidbody2D.velocity.y+ 0.35f;
			rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x,t);

				} else if (coll.gameObject.tag == "Red") {
			float d = rigidbody2D.velocity.y - .25f;
			rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x,d);
		} else if (coll.gameObject.tag == "Finish") {
			//Debug.LogError ("hit");
			//runs++;
		}

	}

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "Finish") {
						//transform.position = new Vector2 (0.1635f, -1.6489f);
						Debug.Log ("trigger Win " + runs);
						runs++;
				}
        else if (coll.gameObject.tag == "climb")
        {
            playing = true;
        }
	}
	
	void FixedUpdate () {
        float move = Input.acceleration.y;
       // float move = Input.GetAxis("Horizontal");
        isClimbing = climbController.isClimbing;
        isMoveLeft = leftController.isClimbing;
        isMoveRight = rightController.isClimbing;
        //Debug.Log("Acceleration = " + move);
        if (move < 0 && isMoveLeft && timer > 10)
        {
            //rigidbody2D.velocity = new Vector2 (move*maxSp, rigidbody2D.velocity.y);
            transform.position = new Vector3(transform.position.x - 1.5f, transform.position.y);
            timer = 0;
        }
        if (move > 0 && isMoveRight && timer > 10)
        {
            transform.position = new Vector3(transform.position.x + 1.5f, transform.position.y);
            timer = 0;
        }
        if (isClimbing && transform.position.y < -1.1)
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.03f);
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
	}
}
