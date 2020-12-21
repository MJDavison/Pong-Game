using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public float xDir = 10f;

    public Rigidbody2D ball;
    // Start is called before the first frame update
    public void SpawnBall()
    {
        Rigidbody2D b = Instantiate(ball);
        b.velocity = -transform.right * xDir;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
