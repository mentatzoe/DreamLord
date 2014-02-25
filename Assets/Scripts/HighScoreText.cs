using UnityEngine;
using System.Collections;

public class HighScoreText : MonoBehaviour {

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
    void Update()
    {
        string ScoreText = "High Score:" + PlayerPrefs.GetInt("High Score");
        guiText.text = ScoreText;
    }

    void OnGUI()
    {
        //GUI.Label(new Rect(10, 10, 100, 90), "High Score: " + PlayerPrefs.GetInt("High Score"));
        //GUIUtility.RotateAroundPivot(90, new Vector2(0, 0));
        // Make a background box
        //GUI.Box(new Rect(10, 10, 100, 90), "High Score: " + PlayerPrefs.GetInt("High Score"));

    }
}
