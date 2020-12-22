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
    Transform target;
    void Awake()
    {
        target = brain.aiPaddle.transform;
    }
    
    // Update is called once per frame

    private void Update() {
        target.position = new Vector2(target.position.x, brain.GM.b.position.y);
        print(target.position.ToString());
    }
    void FixedUpdate()
    {
        
        brain.aiPaddle.transform.position = Vector3.MoveTowards(brain.aiPaddle.transform.position, target.position, Time.deltaTime* movementSpeed);
    }

    public void MoveUp(){
        print("Move Up");
        brain.aiPaddle.transform.Translate(Vector3.up * Time.deltaTime * movementSpeed);
        
    }

    public void MoveDown(){
        print("Move Down");
        brain.aiPaddle.transform.Translate(Vector3.down * Time.deltaTime * movementSpeed);
    }
}
