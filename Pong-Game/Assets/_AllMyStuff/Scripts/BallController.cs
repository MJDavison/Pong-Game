using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    GameManager GM;

    
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "KillZone"){
            if(other.name == "RightWall"){
                GM.scoreManager.playerScores();               
            }else if(other.name == "LeftWall"){
                GM.scoreManager.aiScores();
            }else if(other.name == "TopBar"||other.name == "BottomBar"){ 
                GM.SpawnBall();
            }
            print(gameObject.transform.position.ToString());
            Destroy(gameObject);
        }

       
       
    }

    private void OnCollisionEnter2D(Collision2D other) {        
        int randomAngle = 0;

        if(other.gameObject.name == "Player"){
            randomAngle = Random.Range(30,50);
        } 
        else if(other.gameObject.name == "AI"){
            randomAngle = Random.Range(-30, -50);
        }
        
        Quaternion targetRotation = Quaternion.Euler(new Vector3(randomAngle, 0,0));
        Vector3 targetDirection = targetRotation * Vector3.right;
        float speed = other.otherRigidbody.velocity.magnitude;
        //other.otherRigidbody.velocity = speed * targetDirection;
        print("Hit Paddle");
        
    }

    
        
    
}
