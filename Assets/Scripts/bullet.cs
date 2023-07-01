using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class bullet : MonoBehaviour
{
    
    private Rigidbody2D rb;

    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 10);
        
    
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
