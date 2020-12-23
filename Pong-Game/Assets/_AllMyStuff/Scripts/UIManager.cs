using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

/**
 * This script will be responsible for manipulating the score text 
 **/
[Serializable]
public class UIManager : MonoBehaviour
{
    [SerializeField]
    GameManager GM;

    [SerializeField]
    public Canvas canvas;
    
    public Text playerScoreText;
    
    public Text aiScoreText;
    // Start is called before the first frame update
    // void Start()
    // {
    //     //print(gameObject.name);
        
    // }

    

    public void UpdateScore(){
        playerScoreText.text = GM.scoreManager.playerScore.ToString();
        aiScoreText.text = GM.scoreManager.aiScore.ToString();
    }
}
