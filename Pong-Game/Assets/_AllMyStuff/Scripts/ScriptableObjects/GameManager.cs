// ----------------------------------------------------------------------------
// Author: MJDeveloping
// Portfolio: https://mjdeveloping.github.io/ 
// ----------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameManager", menuName = "GameManager")]
public class GameManager : ScriptableObject
{    
    [SerializeField]
    public ScoreManager scoreManager;
    
    
    public UIManager uiManager;       
    public GameInit gameInit;

    public Rigidbody2D ball;   

    public void Init(){
        uiManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<UIManager>();
        gameInit = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameInit>();
        scoreManager.ResetScores();
    }
    public Rigidbody2D b;
    public float ballSpeed = 10; 
    public void SpawnBall(){
        float xAngle;
        
        int side = Random.Range(0,2);
        
        

        if(side == 0){
            xAngle = Random.Range(-5,-3);
        }else{
            xAngle = Random.Range(3, 5);
        }
        b = Instantiate(ball, Vector2.zero, Quaternion.Euler(0, xAngle,0));
        b.velocity = new Vector3(xAngle, 0,0);
        //b.velocity.Set(xAngle,0);
    }


    public void GameOver(){
        Debug.Log("Game Over");
        scoreManager.ResetScores();
        Debug.Log("Game Over");
    }    
}

