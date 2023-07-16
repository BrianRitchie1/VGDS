using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{

    public int maxHealth;
    private int health_p;

    // Start is called before the first frame update
    void Start()
    {
        health_p = maxHealth;
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            health_p -= 1;
            if (health_p <= 0)
            {
                Destroy(gameObject);
                UIScript.score += 100;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
