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

        
        if(Keyboard.current.pKey.wasPressedThisFrame && bettermovement.isAlive)
        {
            bullet = Instantiate(bulletPrefab, shootingPoint.position, transform.rotation).GetComponent<Rigidbody2D>();
            
            

            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector2 movement = new Vector2(moveHorizontal, moveVertical);
            bullet.velocity = movement * speed;
            if (bullet.velocity.magnitude == 0)
            {
                if(bettermovement.isFacingRight)
                {
                    bullet.velocity = new Vector2(speed, 0);
                }

                else {
                    bullet.velocity = new Vector2(-speed, 0);
                }
            }
            else{
                bullet.velocity *= speed / bullet.velocity.magnitude;
            }
        }

            

            
        

            
            
    }
        
}

