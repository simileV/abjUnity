using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpHelper : MonoBehaviour
{
    private bool shouldLerp = false;

    public Vector3 startPos;
    public Vector3 endPos;
    public float timeStartedLerping;
    public float lerpTime;

    private void StartLerping()
    {
        timeStartedLerping = Time.time;
        shouldLerp = true;

    }

    // Start is called before the first frame update
    void Start()
    {
        //StartLerping();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            StartLerping();
        }

        if (shouldLerp)
        {
            //timeStartedLerping = Time.time;
            //print("in should Lerp");
            transform.position = Lerp(startPos, endPos, timeStartedLerping, lerpTime);
        }

        //if (shouldLerp)
        //{
        //    //print("in should Lerp");
        //    transform.position = Lerp(startPos, endPos, timeStartedLerping, lerpTime);
        //}
    }

    public Vector3 Lerp(Vector3 start, Vector3 end, float timeStartedLerping, float lerpTime)
    {
        float timeSinceStarted = Time.time - timeStartedLerping;
        float percent01 = timeSinceStarted / lerpTime;
        var result = Vector3.Lerp(start, end, percent01);

        return result;
    }
}
