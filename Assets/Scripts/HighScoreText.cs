using UnityEngine;
using System.Collections;

public class HighScoreText : MonoBehaviour {

	private string[] sentences = new string[10]{"Do you know the terror of he who falls asleep?",
		"Why follow your dreams when you can follow your nightmares?",
		"Memories can be your best dreams or your worse nightmares.",
		"...To dream those dreams until the day we live them.",
		"I'm suddenly finding it hard to know the difference between nightmares and consciousness",
		"They've promised dreams can come true- but forget to mention that dreams are nightmares, too",
		"You don't have to sleep, you don't have to dream, to have nightmares.",
		"Are you sure you're awake?",
		"The real nightmare begins when you wake up.",
		"What do monsters have nightmares about?"};

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
    void Update()
    {
        string ScoreText = sentences[GameManager.score%10]+ "\n" + PlayerPrefs.GetInt("High Score");
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
