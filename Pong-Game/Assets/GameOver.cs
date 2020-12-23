using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] Text myWinText;
    [SerializeField] [TextArea(minLines:3,maxLines:50)] 
    string winText;
    string WinLose;
    [SerializeField] GameManager myGM;
    

    private void Awake() {
        
    }
    // Start is called before the first frame update
    private void OnEnable() {
        if(myGM.playerWin){
            WinLose = "win";
        } else{
            WinLose = "lose";
        }
        winText = "You "+ WinLose+"!\n"+
        "Final Score: "+ 
        myGM.scoreManager.playerScore +" : " +myGM.scoreManager.aiScore;

        myWinText.text = winText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
