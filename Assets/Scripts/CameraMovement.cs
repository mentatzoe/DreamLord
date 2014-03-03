using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
    public bool isClimbing;
    PlayerController controller;
	// Use this for initialization
	void Start () {
        GameObject player = GameObject.Find("Character");
        controller = player.GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
        isClimbing = controller.isClimbing;
        if (!isClimbing && controller.playing)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y +0.04f, transform.position.z);
        }
	}
}
