using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 15f;
    public float mapWidth = 5f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime;

        Vector2 newPosition = rb.position + Vector2.right * x;

        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);


        rb.MovePosition(newPosition);
    }
}
