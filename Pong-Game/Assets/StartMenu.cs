using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    [SerializeField] GameManager myGM;


    public void StartGame(){
        print("Start Game");
        myGM.GameParent.SetActive(true);
        myGM.StartMenuParent.SetActive(false);
        
    }
}
