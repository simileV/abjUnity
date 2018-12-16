using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptA : MonoBehaviour
{
    public float speed = 0.0f;
    public float distance = 10.0f;
    public float time = 5.0f;

    public float maxSpeedLimit = 70.0f;
    public float minSpeedLimit = 40.0f;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            SpeedCheck();
        }
    }

    void SpeedCheck()
    {
        speed = distance / time;

        if (speed > maxSpeedLimit)
        {
            print("you are exceeding the speed limit!");
        }

        else if (speed < minSpeedLimit)
        {
            print("you are below the speed limit!");
        }

        else
        {
            print("you are within the speed limit");
        }

        print("you are traveling at : " + speed + " MPH");
    }
}
