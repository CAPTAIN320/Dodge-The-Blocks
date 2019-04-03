﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 10f;
    public float mapWidth = 3f;

    private Rigidbody2D rb;

    void Start()
    {
        // Get the Player Prefab
        rb = GetComponent<Rigidbody2D>(); 
    }
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime;

        // Move player in both left & right by multiplying by x
        Vector2 newPosition = rb.position + (Vector2.right * x); // 

        // Restrict player position on screen
        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);


        rb.MovePosition(newPosition);
    }

    private void OnCollisionEnter2D()
    {
        FindObjectOfType<GameManager>().EndGame();
        Debug.Log("We got Hit");
    }

}
