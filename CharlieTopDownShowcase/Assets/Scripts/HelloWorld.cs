using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
        string name = "Name";
        Debug.Log(name);
        int health = 10;
        Debug.Log("Health = " + health);
        float critChance = 0.2f;
        bool key = true;
        //all below subtract 1 from health
        health = health - 1;
        health--;
        health -= 1;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
