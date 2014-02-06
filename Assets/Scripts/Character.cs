using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

	// Use this for initialization
	private Component collider;
	void Start () {
		collider = gameObject.GetComponent("CircleCollider");
		if (collider != null) {
						Debug.Log ("Got it");
		} else {
			Debug.Log("nope");			
		}
	}

	/*void OnControllerColliderHit(ControllerColliderHit hit) {
		if (hit.collider.CompareTag("Box")) {
			//Climbing
		}
	}*/

	/*function OnCollisionEnter(collider:Collision){
		if(collider.gameObject.name=="Box"){
			Debug.Log("hit box");
		}
	}*/
	// Update is called once per frame
	void Update () {

	}
}
