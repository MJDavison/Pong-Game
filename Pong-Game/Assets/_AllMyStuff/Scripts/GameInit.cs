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
        // StartCoroutine(StartGame());
    }

    // IEnumerator StartGame(){        
    //     yield return new WaitForSeconds(1);
    //     GM.SpawnBall();
    // } 

    public void RespawnBall(){
        GM.ball.SetActive(false);
        GM.ball.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        StartCoroutine(RecenterBall());
    }
    
    

    IEnumerator RecenterBall(){        
        yield return new WaitForSeconds(1);
        GM.ball.transform.position = Vector3.zero;
        //GM.ball.GetComponent<Rigidbody2D>().position = Vector3.zero;
        GM.ball.SetActive(true);
    } 

    
}
