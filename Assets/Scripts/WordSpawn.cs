using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
public class WordSpawn : MonoBehaviour {

	GameObject t;
	public int id;
	public bool ready = true;
	private string[] words = {"we","don't","see","things","as","they","are","we","them"};
	private string[] badWords = new string[7];
	private string[] goodWords = new string[7];
	private string[] familyWords = {"duty", "kids", "love", "home", "together", "marriage", "bonds"};
	private string[] adventureWords = {"risk", "unknown", "exciting", "thrills", "adrenaline", "stories", "freedom"};
	private Dictionary<GameObject, int> wordTypes = new Dictionary<GameObject, int>();

	void Start(){

	}

	/*private GameObject wordRegular(){
		GameObject w = (GameObject) Resources.Load ("Text");
		TextMesh tt = w.GetComponent<TextMesh>();
		int r = UnityEngine.Random.Range (0, words.Length - 1);
		tt.text = words [r];
		return w;
		}

	private GameObject wordGood(){
		GameObject w = (GameObject) Resources.Load ("GoodWord");
		TextMesh tt = w.GetComponent<TextMesh>();
		tt.text = goodWords [UnityEngine.Random.Range (0, goodWords.Length)];
		return w;
	}

	private GameObject wordBad(){
		GameObject w = (GameObject) Resources.Load ("BadWord");
		TextMesh tt = w.GetComponent<TextMesh>();
		tt.text = badWords [UnityEngine.Random.Range (0, badWords.Length)];
		return w;
	}*/

	IEnumerator Spawn() {
		ready = false;

		while (true) {
			yield return new WaitForSeconds (0.3f);
			//wordTypes.Add (wordRegular(), 70);
			//wordTypes.Add (wordGood(), 3);
			//wordTypes.Add (wordBad(), 3);
            int rand = UnityEngine.Random.Range(0, 4);
		    GameObject word = (GameObject) Resources.Load ("CrackedBox");
            if(rand <= 2)
                word = (GameObject) Resources.Load ("box");
			Instantiate (word);
			int diffX = UnityEngine.Random.Range(0, 3);
			int diffY = UnityEngine.Random.Range(0, 4);
			word.transform.position = new Vector3(this.transform.position.x,this.transform.position.y);
			wordTypes.Clear ();
		}
		ready = true;
	}

	void FixedUpdate () {
		if (ready) {

						StartCoroutine (Spawn ());
				}
	}
}
