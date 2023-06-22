using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class better_movement : MonoBehaviour
{


    public float speed = 5f;  // Speed of the player movement



    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb.velocity = movement * speed;
    }
}