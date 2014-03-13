using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	private static GameManager instance;
	private static float MAX_GRAV = -30F;
	private float initialGravity= -10F;
	private float stepGravity = 0;
	private float newGrav = 0;
	public static int TOTAL_RUNS = 1;
	public static int score;
	private int runs;
	public bool connected = false;


	public static GameManager Instance {
		get {
			if (instance == null) {
				Debug.Log("Instance null, creating new GameManager");
				instance = new GameObject("GameManager").AddComponent<GameManager>();
			}
			return instance;
		}
	}

	/*
		Setting up controls for the finishing condition
	 */

	public void finishedMiniGame(){
		DontDestroyOnLoad (this);
		//Application.LoadLevel ("MainRoom");
	}

	public void finishGame(){
		DontDestroyOnLoad (this);
		Application.LoadLevel ("MiniGame");
	}

	void Awake() {
		Physics2D.gravity = new Vector2 (0, initialGravity);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		stepGravity += Time.deltaTime * -0.05f;
		//Debug.Log(newGrav);
		if (newGrav >= MAX_GRAV) {
			newGrav = initialGravity + stepGravity;
			//Debug.Log(newGrav);
		}
		Physics2D.gravity = new Vector2 (0, newGrav);
	
		int units = score%10;
		int dec = score/10%10;
		int cent = score/100%10;
		int mil = score/1000%10;
		Debug.Log ("score is "+ mil + cent + dec + units );
	}
}
