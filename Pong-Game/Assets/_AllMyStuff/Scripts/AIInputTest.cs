using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIInputTest : MonoBehaviour
{

    [SerializeField]
    AIBrainScript aiBrain;
   internal bool isUpPressed;
    internal bool isDownPressed;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            isUpPressed = true;
        }else{
            isUpPressed = false;
        }

        if(Input.GetKey(KeyCode.DownArrow)){
            isDownPressed = true;
        }else{
            isDownPressed = false;
        }
    }
}
