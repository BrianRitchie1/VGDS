using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bulletPrefab;
    private Rigidbody2D bullet;
    public float speed;

    // Update is called once per frame
    void Update()
    {

        
        if(Keyboard.current.pKey.wasPressedThisFrame)
        {
            bullet = Instantiate(bulletPrefab, shootingPoint.position, transform.rotation).GetComponent<Rigidbody2D>();
            
            if (Input.GetKey ("w"))
            {
                bullet.velocity = new Vector2(0, speed);
            }

            if (Input.GetKey ("s"))
            {
                bullet.velocity = new Vector2(0, -speed);
            }
            
            else {
                if(bettermovement.isFacingRight)
                {
                    bullet.velocity = new Vector2(speed, 0);
                }

                else {
                    bullet.velocity = new Vector2(-speed, 0);
                }
            }

            
            
        }
        
    }
}
