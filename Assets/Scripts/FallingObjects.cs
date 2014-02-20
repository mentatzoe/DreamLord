﻿using UnityEngine;
using System.Collections;

public class FallingObjects : MonoBehaviour {

	// Use this for initialization
    public int timer;
	void Start () {
        timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
        timer++;
        if (timer > 100)
        {
            Spawn();
            timer = 0;
        }
	}

    void Spawn()
    {
        int rand = UnityEngine.Random.Range(0, 10);
        if (rand == 2)
        {
            Debug.Log("spawn called");
            GameObject fallingObject = (GameObject)Resources.Load("FallingObject");
            Instantiate(fallingObject);
            fallingObject.transform.position = new Vector3(this.transform.position.x, this.transform.position.y);
        }

    }
}