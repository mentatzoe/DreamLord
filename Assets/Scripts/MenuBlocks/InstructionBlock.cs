using UnityEngine;
using System.Collections;

public class InstructionBlock : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDown(){
		Camera.main.transform.position = new Vector3(-13, -1, -10);
		audio.Play ();
	}
}
