using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "KillZone"){
            if(gameObject.transform.position.x < 0){
                //Player Score + 1                
            }else if(gameObject.transform.position.x > 0){
                //Enemy Score + 1;
            }else{
                //Ball somehow fell at x 0... respawn the ball and don't increment either score. This shouldn't happen, ever.
            }
            Destroy(gameObject);
        }    
    }
        
    
}
