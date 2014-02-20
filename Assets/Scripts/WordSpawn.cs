using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
public class WordSpawn : MonoBehaviour {

	GameObject t;
	public int id;
	public bool ready = true;
    public bool spawn = true;
	private string[] words = {"we","don't","see","things","as","they","are","we","them"};
	private string[] badWords = new string[7];
	private string[] goodWords = new string[7];
	private string[] familyWords = {"duty", "kids", "love", "home", "together", "marriage", "bonds"};
	private string[] adventureWords = {"risk", "unknown", "exciting", "thrills", "adrenaline", "stories", "freedom"};
	private Dictionary<GameObject, int> blockTypes = new Dictionary<GameObject, int>();

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
            yield return new WaitForSeconds(0.2f);
            if (spawn)
            {
                blockTypes.Add((GameObject)Resources.Load("box"), 30);
           //     blockTypes.Add((GameObject)Resources.Load("CrackedBox"), 3);
				blockTypes.Add((GameObject)Resources.Load("DragBox"), 3);
				//wordTypes.Add (wordGood(), 3);
                //wordTypes.Add (wordBad(), 3);
                GameObject word = WeightedRandomizer.From(blockTypes).TakeOne();
                Instantiate(word);
                int diffX = UnityEngine.Random.Range(0, 3);
                int diffY = UnityEngine.Random.Range(0, 3);
                word.transform.position = new Vector3(this.transform.position.x, this.transform.position.y);
                blockTypes.Clear();
            }
		}
		ready = true;
	}

	void FixedUpdate () {
		if (ready) {

						StartCoroutine (Spawn ());
				}
        spawn = true;
	}
    
    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "climb")
        {
            //Debug.Log("not ready");
            spawn = false;
        }
    }
     
}
