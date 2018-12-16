using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpOfficial : MonoBehaviour
{
    public float lerpSpeed = 2.0f;
    public Vector3 startVec;
    public Vector3 endVec;

    // Start is called before the first frame update
    void Start()
    {
        endVec = transform.position;
    }

    // Update is called once per frame
    void Update()
    {


        transform.position = Vector3.Lerp(startVec, endVec, Time.deltaTime * lerpSpeed);

    }

    //public Vector3 Lerp(Vector3 start, Vector3 end)
    //public Vector3 Lerp()
    //{
        //return Vector3.Lerp(startVec, endVec, Time.deltaTime * lerpSpeed);
    //}
}
