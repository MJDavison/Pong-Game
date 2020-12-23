using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    
    GameManager GM;
    Rigidbody2D rb;
    Vector2 direction;

    
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "KillZone"){
            GM.scoreManager.Score();                    
        }           
    }

    private float PositionOnPaddle(Vector2 ballPos, Vector2 paddlePos, float paddleHeight){

        return (ballPos.y  - paddlePos.y) / paddleHeight;
    }
    

    private void Start() {
        
        rb = GetComponent<Rigidbody2D>();        
        direction = new Vector2(-1,0); 
        rb.velocity = direction * GM.ballSpeed;
        // print(direction);
    }

    private void FixedUpdate() {
        rb.velocity = direction * GM.ballSpeed;
    }

    private void OnCollisionEnter2D(Collision2D other) {        
        // if(other.gameObject.CompareTag("Wall")){
        //     float x = PositionOnPaddle(transform.position, other.transform.position, other.collider.bounds.size.x);
        //     x = x*50;
        //     if(other.gameObject.name == "TopWall"){
        //         direction = new Vector2(1,x);
        //     }
        //     else if(other.gameObject.name=="BottomWall"){
        //         direction = new Vector2(-1,x);
        //     }
        //     rb.velocity = direction * GM.ballSpeed;
            
        //     print("Wall bounce: "+ rb.velocity);
        //     print(other.gameObject.name+"bounce: " + rb.velocity);      
              direction = new Vector2(1, -direction.y);
        // }
        // else
         if(other.gameObject.CompareTag("Paddle")){
            float y = PositionOnPaddle(transform.position, other.transform.position, other.collider.bounds.size.y);            
            if(other.gameObject.name =="LeftPaddle"){
                direction = new Vector2(1, y).normalized;                
            } else if(other.gameObject.name=="RightPaddle"){
                direction = new Vector2(-1, y).normalized;
            }
            rb.velocity = direction * GM.ballSpeed;     
            print(other.gameObject.name+"bounce: " + rb.velocity);                                       
        }        
        
    }

    
        
    
}
