using UnityEngine;
using System.Collections;

public class ParallaxScrolling : MonoBehaviour {


	public float scrollSpeed = 0;
	// Update is called once per frame
	void Update () {
		float offset = Time.time * scrollSpeed;
		renderer.material.mainTextureOffset = new Vector2(0, offset % 1);
	}
}
