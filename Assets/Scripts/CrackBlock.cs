using UnityEngine;
using System.Collections;
using System;

public class CrackBlock : MonoBehaviour {

	// Use this for initialization
    public int clicks;
	public int timer;
    void Start()
    {
		timer= -1;
        clicks = 1;
    }
    public void OnMouseDown()
    {
        if(Input.GetMouseButton(0)){
            --clicks;
			timer=50;
			audio.Play ();       

           // Destroy(gameObject);
            Debug.Log("clicks is = " + clicks);
        }
    }
 
	// Update is called once per frame
	void Update () {
		if (clicks==0){
			transform.position = new Vector3 (20,20,20);
		}
        if (timer == 0){
			Destroy(gameObject);
		}

	}
}
