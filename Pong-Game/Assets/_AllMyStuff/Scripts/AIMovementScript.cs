using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovementScript : MonoBehaviour
{
    [SerializeField]
    AIBrainScript brain;
    [SerializeField]
    int movementSpeed = 5;
    // Start is called before the first frame update
        
    // Update is called once per frame
    float targetYCoord = 0;
    private void Update() {
        targetYCoord = FollowBall();        
    }


    
    void FixedUpdate()
    {        
       brain.aiPaddle.transform.position = new Vector3(brain.aiPaddle.transform.position.x, targetYCoord, brain.aiPaddle.transform.position.z);
    }

    public void MoveUp(){
        print("Move Up");
        brain.aiPaddle.transform.Translate(Vector3.up * Time.deltaTime * movementSpeed);
        
    }

    public void MoveDown(){
        print("Move Down");
        brain.aiPaddle.transform.Translate(Vector3.down * Time.deltaTime * movementSpeed);
    }

    public float FollowBall(){
         return Mathf.MoveTowards(brain.aiPaddle.transform.position.y, brain.GM.ball.transform.position.y,movementSpeed);
    }
}
