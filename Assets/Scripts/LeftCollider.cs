using UnityEngine;
using System.Collections;

public class LeftCollider : MonoBehaviour {
	public bool Colliding = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D collision) {
		Colliding = true;

	}
	void OnCollisionExit2D(Collision2D collision) {
		Colliding = false;
	}

}
