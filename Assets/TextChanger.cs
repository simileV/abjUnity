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
    public AudioSource audioSource;

    private string[] taskList = new string[6];

    void TaskRoster()
    {
        taskList[0] = "play Injustice";
        taskList[1] = "play Injustice 2";
        taskList[2] = "play Killer instinct";
        taskList[3] = "play KoF 13";
        taskList[4] = "play KoF 14";
        taskList[5] = "play League";
    }

    Color textColor = Color.white;

    // Start is called before the first frame update
    void Start()
    {
        audioSource.GetComponent<AudioSource>();
        //endVec = transform.position;

        TaskRoster();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            StartLerping();
            audioSource.PlayOneShot(myAudioClip, 1.0f);

            int taskID = Random.Range(0, taskList.Length - 1);
            //print("taskID = " + taskID);
            //print("taskList size 0 = " + taskList.Length);
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
