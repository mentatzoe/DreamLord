using UnityEngine;
using System.Collections;

public class TouchDrag : MonoBehaviour {
	public int cooldown;

	// Use this for initialization
	void Start () {
		cooldown = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (cooldown > 0) {
			cooldown--;
		}
	
	}

void OnTriggerEnter2D(Collider2D other)
{
	if (other.tag=="drag"){
		if (cooldown==0){
			audio.Play();
			cooldown = 50;
		}
	}
}
}