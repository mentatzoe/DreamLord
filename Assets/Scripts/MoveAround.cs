using UnityEngine;
using System.Collections;

public class MoveAround : MonoBehaviour {

	private float y;
	public bool stacking= false;
	public bool sInc = false; 
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	/*Debug.Log (this.transform.position.y);
		y = this.transform.position.y-0.1f;
		transform.position = new Vector3(this.transform.position.x, y, this.transform.position.z);*/

	}
	

	void OnCollisionExit2D(Collision2D coll){
		//if (stacking)
		//GameManager.Instance.score--;
	}

	void OnBecameInvisible () {
		Destroy(gameObject);
	}
}
