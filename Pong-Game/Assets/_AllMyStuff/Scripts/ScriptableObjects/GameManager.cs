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

    [SerializeField] public GameObject StartMenuParent;
    [SerializeField] public GameObject GameParent;
    [SerializeField] GameObject WinLoseParent;


    [SerializeField]
    public ScoreManager scoreManager;
    
    public UIManager uiManager;       
    public GameInit gameInit;
    
    public GameObject ball;   
    public Rigidbody2D ballRB;
    public bool playerWin;

    public float ballSpeed = 10; 
    public void Init(){
        uiManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<UIManager>();
        gameInit = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameInit>();
        ball = GameObject.FindGameObjectWithTag("Ball");

        StartMenuParent = GameObject.Find("StartMenu");
        GameParent = GameObject.Find("Game");
        WinLoseParent = GameObject.Find("WinLose");

        
        GameParent.SetActive(false);
        WinLoseParent.SetActive(false);
        

        ballRB = ball.GetComponent<Rigidbody2D>();
        scoreManager.ResetScores();
    }
    
    
    public void GameOver(){
        Debug.Log("Game Over");
        GameParent.SetActive(false);
        WinLoseParent.SetActive(true);
        scoreManager.ResetScores();       
    }    
}

