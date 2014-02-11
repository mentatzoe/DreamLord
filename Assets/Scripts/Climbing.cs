using UnityEngine;
using System.Collections;

public class Climbing : MonoBehaviour {

	// Use this for initialization
    public bool isClimbing = false;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "climb")
        {
            isClimbing = true;
        }
    }

    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "climb")
        {
            isClimbing = true;
        }
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "climb")
        {
            isClimbing = false;
        }
    }
}
