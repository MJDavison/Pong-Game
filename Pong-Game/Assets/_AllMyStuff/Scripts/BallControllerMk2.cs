using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControllerMk2 : MonoBehaviour
{

    internal bool moveLeft;
    internal bool moveRight;

    [SerializeField]
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update() {
        if(Input.GetKey(KeyCode.A)){
            moveLeft = true;            
        }
        else{
            moveLeft = false;
        }

        if(Input.GetKey(KeyCode.D)){
            moveRight = true;
        }
        else{
            moveRight = false;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if(moveLeft){
            rb.velocity = new Vector2(-1.0f, 0.0f);
            print("Move Left");
        }
        else
        {
            rb.velocity = Vector3.zero;
        }

        if(moveRight){
            rb.velocity = new Vector2(1.0f, 0.0f);
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
    }
}
