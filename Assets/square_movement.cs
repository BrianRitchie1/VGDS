using System;

using System.Collections;

using System.Collections.Generic;

using UnityEngine;

 

public class square_movement : MonoBehaviour

{

    private Rigidbody2D player;

    private float speed = 2;

    private float speedcap = 10;

    // private float drag = 3;

    // private float jumpheight = 1;

 

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

       

    }

}