using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : BrainBase
{
    [SerializeField]
    GameManager GM;
    [SerializeField]
    public MovementScript movement;

    [SerializeField]
    public PlayerInputScript input;    
    public GameObject playerPaddle;
    
    // Start is called before the first frame update
    void Start()
    {
        playerPaddle = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
