using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TMP_changeText : MonoBehaviour
{
    //private TextMeshPro textMesh;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMeshPro>().text = "Play Injustice 1";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
