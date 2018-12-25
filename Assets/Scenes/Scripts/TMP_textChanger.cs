using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TMP_textChanger : MonoBehaviour
{
    public Vector3 startVec;
    public Vector3 endVec;
    private float currentLerpTime;
    //public float lerpSpeed = 2.0f;
    public float lerpSpeed = 1.0f;

    private float timeStartedLerping;
    private bool shouldLerp = false;
    //private bool shouldLerp = true;

    public AudioClip myAudioClip;
    public AudioSource audioSource;

    private string[] taskList = new string[41];

    void TaskRoster()
    {
        taskList[0] = "play Blazblue";
        taskList[1] = "play Diablo 2";
        taskList[2] = "play Diablo 3";
        taskList[3] = "play DMC 3";
        taskList[4] = "play DMC 4";
        taskList[5] = "play Dota2";
        taskList[6] = "play Guilty Gear";
        taskList[7] = "play Hearthstone";
        taskList[8] = "play Heroes of the Storm";
        taskList[9] = "play Hollow Knight";
        taskList[10] = "play Ikaruga";
        taskList[11] = "play Injustice 1";
        taskList[12] = "play Injustice 2";
        taskList[13] = "play Killer instinct";
        taskList[14] = "play KoF 13";
        taskList[15] = "play KoF 14";
        taskList[16] = "play League";
        taskList[17] = "play Marvel Vs Capcom 3";
        taskList[18] = "play Marvel vs Capcom Infinite";
        taskList[19] = "play Mortal Kombat 9";
        taskList[20] = "play MKX";
        taskList[21] = "play Skullgirls";
        taskList[22] = "play Starcraft";
        taskList[23] = "play Starcraft 2";
        taskList[24] = "play Street Fighter 4";
        taskList[25] = "play Street Fighter 5";
        taskList[26] = "play Fortnite";
        taskList[27] = "roll again";
        taskList[28] = "roll again";
        taskList[29] = "roll again";

        taskList[30] = "learn Blender";
        taskList[31] = "learn GIMP";

        taskList[32] = "model starcraft unit";
        taskList[33] = "model a stargate";

        taskList[34] = "read TWD";
        taskList[35] = "read Street F";

        taskList[36] = "bloom";
        taskList[37] = "motion blur";
        taskList[38] = "lens flare";

        taskList[39] = "FL studio";
        taskList[40] = "organize Spotify playlists";
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

            print("random task = " + taskList[taskID]);
            //GetComponent<TextMesh>().text = taskList[taskID];
            GetComponent<TextMeshPro>().text = taskList[taskID];
        }

        if (shouldLerp)
        {
            currentLerpTime += Time.deltaTime;
            //transform.position = Vector3.Lerp(startVec, endVec, currentLerpTime * lerpSpeed);
            transform.position = Lerp3(startVec, endVec, currentLerpTime * lerpSpeed);

            textColor.a = Lerp1(1.0f, 0.0f, currentLerpTime * lerpSpeed);
            GetComponent<TextMeshPro>().color = textColor;
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
