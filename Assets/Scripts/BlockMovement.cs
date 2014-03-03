﻿using UnityEngine;
using System.Collections;

public class BlockMovement : MonoBehaviour
{
    public int time;
    PlayerController controller;
    public bool isClimbing;
    public float fallSpeed;
    int score;
    float increase;
    // Use this for initialization
    void Start()
    {
        fallSpeed = 0.03f;
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
        increase = score * 0.0005f;
        fallSpeed = 0.03f + increase;
        if (isClimbing)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - fallSpeed, transform.position.z);
        }
        if (!controller.playing)
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.10f, transform.position.z);

    }
}