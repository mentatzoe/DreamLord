using UnityEngine;
using System.Collections;

public class ScoreText : MonoBehaviour {
    PlayerController controller;

	// Use this for initialization
	void Start () {
        GameObject player = GameObject.Find("Character");
        controller = player.GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<TextMesh>().text = "Score: " + controller.score;
	}
}
