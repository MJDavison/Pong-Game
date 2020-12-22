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
    

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
        direction = Vector2.one.normalized; 
    }

    private void FixedUpdate() {
        rb.velocity = direction * GM.ballSpeed;
    }

    private void OnCollisionEnter2D(Collision2D other) {        
        if(other.gameObject.CompareTag("Wall")){
            direction.y = -direction.y;
        }
        else if(other.gameObject.CompareTag("Paddle")){
            direction.x = -direction.x;
        }        
        
    }

    
        
    
}
