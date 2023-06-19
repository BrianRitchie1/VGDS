using System;

using System.Collections;

using System.Collections.Generic;

using UnityEngine;

 

public class square_movement : MonoBehaviour

{

    private Rigidbody2D player;

    public float speed = 2;

    public float speedcap = 10;

    // private float drag = 3;

    public float jumpheight = 1;

    private bool canJump;

 

    private void Awake()

    {

        Application.targetFrameRate = 60;

        player = GetComponent<Rigidbody2D>();

    }

 

    // Start is called before the first frame update

    void Start()

    {

       

    }

 

    // Update is called once per frame

    void Update()

    {

        if (Math.Abs(player.velocity.x) < speedcap)

        {

            player.velocity += new Vector2(Input.GetAxis("Horizontal") * speed, 0);

        }    
        if (Input.GetButtonDown("Jump") && canJump)
        {
            player.velocity += new Vector2(0, jumpheight);
            canJump = false;
        }


    }
    void OnCollisionEnter2D()
    {
        canJump = true;
    }

}