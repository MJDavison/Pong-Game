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
    
    Text playerScoreText;
    
    Text aiScoreText;
    // Start is called before the first frame update
    void Start()
    {
        print(gameObject.name);
        playerScoreText = GameObject.Find("Left_Score").GetComponentInChildren<Text>();
        aiScoreText = GameObject.Find("Right_Score").GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(){
        playerScoreText.text = GM.scoreManager.playerScore.ToString();
        aiScoreText.text = GM.scoreManager.aiScore.ToString();
    }
}
