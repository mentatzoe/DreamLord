using UnityEngine;
using System.Collections;
public class DragBlock : MonoBehaviour {
    private Vector3 screenPoint;
    private Vector3 offset;
    private bool sliding;
	// Use this for initialization
	void Start () {
        sliding = true;
	}


    void OnMouseDrag()
    {
        if (sliding)
        {
            float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
            Vector3 pos_move = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));
            transform.position = new Vector3(pos_move.x, pos_move.y, pos_move.z);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
		if (other.tag=="player"){
      		sliding = false;
		}
    }
	
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
	
	// Update is called once per frame
    void Update()
    {
        
    }
}
