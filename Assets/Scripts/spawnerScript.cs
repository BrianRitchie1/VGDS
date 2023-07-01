using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerScript : MonoBehaviour
{

    public GameObject enemy;
    private int timer = 120;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= 1;
        if (timer <= 0)
        {
            transform.position = new Vector2(Random.Range(-40,40), 65);
            Instantiate(enemy, transform.position, transform.rotation);
            timer = 120;
        }
    }
}
