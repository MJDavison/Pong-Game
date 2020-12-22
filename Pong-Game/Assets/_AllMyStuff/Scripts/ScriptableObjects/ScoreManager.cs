// ----------------------------------------------------------------------------
// Author: MJDeveloping
// Portfolio: https://mjdeveloping.github.io/ 
// ----------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScoreManager", menuName = "ScoreManager")]
[Serializable]
public class ScoreManager : ScriptableObject
{
    [SerializeField]
    PlayerScript player;

    [SerializeField]
    AIBrainScript ai;

    [SerializeField]
    GameManager GM;

    public int playerScore;
    public int aiScore;

    public void playerScores(){
        playerScore++;
        UpdateScore();
        
    }

    public void aiScores(){
        aiScore++;
        UpdateScore();
    }

    public void UpdateScore(){
        GM.uiManager.UpdateScore();
        if(aiScore == 11 || playerScore == 11){
            GM.GameOver();
        }        
    }

    public void ResetScores(){
        playerScore = 0;
        aiScore = 0;
    }

    public void Score(){
        if(GM.ball.transform.position.x < 0){
            aiScores();
        }
        else{
            playerScores();
        }
        Debug.Log(GM.ball.transform.position.ToString());
            GM.gameInit.RespawnBall();
    }
}
