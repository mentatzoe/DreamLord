using UnityEngine;
using System.Collections;

public class FallingObjectMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x, transform.position.y - 0.10f, transform.position.z);
	}
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
