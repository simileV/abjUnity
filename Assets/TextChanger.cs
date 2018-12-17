using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextChanger : MonoBehaviour
{
    public Vector3 startVec;
    public Vector3 endVec;
    private float currentLerpTime;
    public float lerpSpeed = 2.0f;
    private float timeStartedLerping;
    private bool shouldLerp = false;
    //private bool shouldLerp = true;

    public AudioClip myAudioClip;
    //AudioSource audioSource;

    Color textColor = Color.white;

    // Start is called before the first frame update
    void Start()
    {
        //endVec = transform.position;
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
            currentLerpTime += Time.deltaTime;
            //transform.position = Vector3.Lerp(startVec, endVec, currentLerpTime * lerpSpeed);
            transform.position = Lerp3(startVec, endVec, currentLerpTime * lerpSpeed);

            textColor.a = Lerp1(1.0f, 0.0f, currentLerpTime * lerpSpeed);
            GetComponent<TextMesh>().color = textColor;
        }
    }

    private void StartLerping()
    {
        currentLerpTime = 0.0f;
        timeStartedLerping = Time.time;
        shouldLerp = true;
    }

    public float Lerp1(float startF, float endF, float factor)
    {
        return Mathf.Lerp(startF, endF, factor);
    }

    public Vector3 Lerp3(Vector3 startF, Vector3 endF, float factor)
    {
        return Vector3.Lerp(startF, endF, factor);
    }
}
