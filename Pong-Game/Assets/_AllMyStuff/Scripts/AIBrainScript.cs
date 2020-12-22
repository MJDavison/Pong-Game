using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This script will be responsible for simulating input for AI.
 * */
public class AIBrainScript : BrainBase
{

    [SerializeField]
    public AIMovementScript movement;
    [SerializeField]   
    public GameManager GM;

    public GameObject aiPaddle;    
    
    

    internal bool moveUp;
    internal bool moveDown;
    

    

    

    
}
