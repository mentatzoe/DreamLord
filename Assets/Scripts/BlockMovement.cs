using UnityEngine;
using System.Collections;

public class BlockMovement : MonoBehaviour
{
	public Sprite sprite1;
	public Sprite sprite2;
	public Sprite sprite3;
	public Sprite sprite4;
	private Sprite[] spritelist = new Sprite[4];
    public int time;
    PlayerController controller;
    public bool isClimbing;
    public float fallSpeed;
    int score;
    float increase;
	public bool isBox = false;
    // Use this for initialization
    void Start()
    {
		if (isBox) {
			spritelist = new Sprite[4]{this.sprite1,sprite2,sprite3,sprite4};
			this.GetComponent<SpriteRenderer> ().sprite = spritelist [Random.Range (0, 3)];
		}

        fallSpeed = 0.01f;
        GameObject player = GameObject.Find("Character");
        controller = player.GetComponent<PlayerController>();
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        time = controller.timer;
        isClimbing = controller.isClimbing;
        score = controller.score;
        increase = score * 0.0004f;
        fallSpeed = 0.01f + increase;
        if (isClimbing)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - fallSpeed, transform.position.z);
        }
        if (!controller.playing)
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.10f, transform.position.z);

    }
}