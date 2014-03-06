using UnityEngine;
using System.Collections;
using System;

public class CrackBlock : MonoBehaviour {

	// Use this for initialization
    public int clicks;
    void Start()
    {
        clicks = 1;
    }
    public void OnMouseDown()
    {
        if(Input.GetMouseButton(0)){
            --clicks;
           // Destroy(gameObject);
            Debug.Log("clicks is = " + clicks);
        }
    }
 
	// Update is called once per frame
	void Update () {
        if (clicks <= 0)
		//				playAudio.audioPlay ();
            Destroy(gameObject); 
	}
}
