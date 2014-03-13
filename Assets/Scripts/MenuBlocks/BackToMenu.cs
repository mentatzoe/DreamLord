using UnityEngine;
using System.Collections;

public class BackToMenu : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDown(){
		Camera.main.transform.position = new Vector3(0.2f, 7.06f, -10);
		audio.Play();
	}
}

