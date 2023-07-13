using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{


    public Text ui;
    public static int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ui.text = "Score: " + UIScript.score + "\nHealth: " + bettermovement.health;

    }
}
