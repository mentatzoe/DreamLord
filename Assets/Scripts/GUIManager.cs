using UnityEngine;
using System.Collections;

public class GUIManager : MonoBehaviour {
    PlayerController controller;
    GUIText GUIScore;
	// Use this for initialization
	void Start () {
        GameObject player = GameObject.Find("Character");
        controller = player.GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
        string ScoreText = "Score :" + controller.score;
        guiText.text = ScoreText;
	}
}
