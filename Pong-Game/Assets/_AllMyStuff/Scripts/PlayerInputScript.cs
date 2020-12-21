using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This script will be responsible for detecting player input.
 * */
public class PlayerInputScript : MonoBehaviour
{  
    [SerializeField]
    PlayerScript player;
    internal bool isUpPressed;
    internal bool isDownPressed;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            isUpPressed = true;
        }else{
            isUpPressed = false;
        }

        if(Input.GetKey(KeyCode.S)){
            isDownPressed = true;
        }else{
            isDownPressed = false;
        }
    }
}
