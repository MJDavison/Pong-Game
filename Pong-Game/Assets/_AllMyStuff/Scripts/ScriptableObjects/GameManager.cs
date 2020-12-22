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
    
    public GameObject ball;   
    public Rigidbody2D ballRB;

    public float ballSpeed = 10; 
    public void Init(){
        uiManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<UIManager>();
        gameInit = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameInit>();
        ball = GameObject.FindGameObjectWithTag("Ball");
        ballRB = ball.GetComponent<Rigidbody2D>();
        scoreManager.ResetScores();
    }
    
    
    public void GameOver(){
        Debug.Log("Game Over");
        scoreManager.ResetScores();       
    }    
}

