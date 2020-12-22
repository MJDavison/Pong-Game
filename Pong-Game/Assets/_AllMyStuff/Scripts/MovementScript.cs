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
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = brain.playerPaddle.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(brain.input.isUpPressed){
            MoveUp();               
        } 
       else if(brain.input.isDownPressed){
            MoveDown();
        }
        else{
            StopMoving();
        }
    }

    public void MoveUp(){
        print("Move Up");
        // brain.playerPaddle.transform.Translate(Vector3.up * Time.deltaTime * movementSpeed);
        rb.velocity = Vector2.up * Time.fixedDeltaTime * movementSpeed;
    }

    public void MoveDown(){
        print("Move Down");
        // brain.playerPaddle.transform.Translate(Vector3.down * Time.deltaTime * movementSpeed);
        rb.velocity = Vector2.down * Time.fixedDeltaTime * movementSpeed;        
    }

    public void StopMoving(){
        rb.velocity = Vector2.zero;
    }
}
