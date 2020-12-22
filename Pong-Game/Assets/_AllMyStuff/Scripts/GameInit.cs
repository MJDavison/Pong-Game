using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInit : MonoBehaviour
{
    [SerializeField]
    public GameManager GM;
    
    [Header("UI")]
    public GameObject canvas;
    public GameObject AIScoreText;
    public GameObject PlayerScoreText;

    public GameObject border;
    public GameObject centerLine;

    [Header("Players")]

    public GameObject player;
    public GameObject ai;

    
    // Start is called before the first frame update

    private void Awake() {
        print("Collecting Prefabs");
    }
    void Start()
    {
        GM.Init();
        StartCoroutine(StartGame());
    }

    IEnumerator StartGame(){        
        yield return new WaitForSeconds(5);
        GM.SpawnBall();
    } 

    
}
