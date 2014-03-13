using UnityEngine;
using System.Collections;

public class Bonus : MonoBehaviour {

	public int timer = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
				timer--;
				if (timer == 0) {
				//		Destroy (gameObject);
				}
		}

void OnTriggerEnter2D(Collider2D other)
{
	if (other.tag=="player"){
			timer = 10;

	}
}
}