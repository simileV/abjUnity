using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class moveTrigger : MonoBehaviour
{
    Vector3 tempPos;
    public float movementSpeed = 100.0f;
    //private System.DateTime startTime;

    /* TIMER */
    //private float waitTime = 2.0f;
    private float timerD = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        //startTime = DateTime.Now;
        //startTime = System.DateTime.Now;
    }

    // Update is called once per frame
    void Update()
    {
        timerD += Time.deltaTime;

        //if (timerD > waitTime)
        //{
            //print(waitTime + "sec has passed");
        //}

        tempPos = transform.position;

        //tempPos.z += .1f;
        tempPos.z += .1f * Time.deltaTime * movementSpeed;

        transform.position = tempPos;
        //transform.position = tempPos * Time.deltaTime * movementSpeed;

        if (Input.GetKeyUp("space"))
        {
            print(timerD + " time has passed");

            //int diffTime = (DateTime.Now - startTime).Seconds;
            //float diffTimeMS = (DateTime.Now - startTime).Milliseconds / 1000.0f;

            //print("diffTime = " + diffTime);
            //print("diffTimeMS = " + diffTimeMS);
            //print("diffTimeMS = " + Time.deltaTime * 1000);
        }
    }
}
