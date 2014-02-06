using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float maxSp = 10f;
	public float run = 10f;
	public int runs = 1;
	// Use this for initialization
	void Start () {
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
		}
	

	void FixedUpdate () {
		float move = Input.GetAxis("Horizontal");
		GameObject rc = GameObject.Find ("Right");
		LeftCollider rightCollider = rc.GetComponent <LeftCollider> ();
		
		GameObject lc = GameObject.Find ("Left");
		LeftCollider leftCollider = lc.GetComponent <LeftCollider> ();
		
		if (rightCollider.Colliding == true && move>=0){
			//transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x+1,transform.position.y), maxSp);
			rigidbody2D.velocity = new Vector2 (move*maxSp, rigidbody2D.velocity.y);
		}
		
		if (leftCollider.Colliding == true && move<=0){
			//transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x-50,transform.position.y), maxSp);
			rigidbody2D.velocity = new Vector2 (move*maxSp, rigidbody2D.velocity.y);
		}
		

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
