using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMesh>().text = "Play Injustice 1";

        Color myColor = Color.white;
        myColor.a = .1f;

        GetComponent<TextMesh>().color = myColor;

        //float newAlpha = 10;
        //GetComponent<TextMesh>().color.a = newAlpha;

        //Color myMat = GetComponent<TextMesh>().color;
        //myMat.a = 0.0f;
        //GetComponent<TextMesh>().color = Vector4(1f, 1f, 1f, 1f);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
