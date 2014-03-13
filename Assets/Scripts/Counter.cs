using UnityEngine;
using System.Collections;

public class Counter : MonoBehaviour {

	public GameObject unit;
	public GameObject dec;
	public GameObject cent;
	public GameObject mil;

	public Sprite zero;
	public Sprite one;
	public Sprite two;
	public Sprite three;
	public Sprite four;
	public Sprite five;
	public Sprite six;
	public Sprite seven;
	public Sprite eight;
	public Sprite nine;

	private Sprite[] numberSprites = new Sprite[10];
	// Use this for initialization
	void Start () {
		numberSprites = new Sprite[10]{zero, one, two, three, four, five, six, seven, eight, nine};
	}

	void FixedUpdate () {
		unit.GetComponent<SpriteRenderer> ().sprite = numberSprites[GameManager.score%10];
		dec.GetComponent<SpriteRenderer> ().sprite = numberSprites[GameManager.score/10%10];
		cent.GetComponent<SpriteRenderer> ().sprite = numberSprites[GameManager.score/100%10];
		mil.GetComponent<SpriteRenderer> ().sprite = numberSprites[GameManager.score/1000%10];
	}
	
}
