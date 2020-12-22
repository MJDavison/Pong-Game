using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This script will be responsible for moving the player OR the enemy movement.
 * */
public class MovementScript : MonoBehaviour
{
    [SerializeField]
    PlayerScript brain;
    [SerializeField]
    int movementSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(brain.input.isUpPressed){
            MoveUp();
        }
        if(brain.input.isDownPressed){
            MoveDown();
        }
    }

    public void MoveUp(){
        print("Move Up");
        brain.playerPaddle.transform.Translate(Vector3.up * Time.deltaTime * movementSpeed);
    }

    public void MoveDown(){
        print("Move Down");
        brain.playerPaddle.transform.Translate(Vector3.down * Time.deltaTime * movementSpeed);
    }
}
