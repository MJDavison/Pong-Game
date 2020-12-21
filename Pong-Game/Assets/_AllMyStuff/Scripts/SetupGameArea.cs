using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This script will be responsible for creating the game area. This includes the following:
 * Spawning the player paddle and opponent paddle prefabs.
 * Spawning the ball prefab.
 * Drawing the dashed line down the vertical center.                                                    Check
 * Creating text elements for the score. Actual score manipulation will be done by another script.
 **/
public class SetupGameArea : MonoBehaviour
{
    //Vector3[] gameAreaCorners;
    //Vector3[] centerLinePoints;
    [Header("Prefabs")]
    [SerializeField]
    private GameObject border; 
    [SerializeField]
    private GameObject middleLine;

    
    public GameObject leftPaddle;
    public GameObject rightPaddle;

    
    //public Material borderMaterial;
    //public Material centerLineMaterial;

    private void Awake() {
        //gameAreaCorners = new Vector3[4];    
        //centerLinePoints = new Vector3[2];
        
        //border = new GameObject();        
        //middleLine = new GameObject();

        //border.AddComponent<LineRenderer>();
        //middleLine.AddComponent<LineRenderer>();
    }     

    private void Start() {
        /*gameAreaCorners[0] = new Vector3(-8.5f, 3.75f, 0);
        gameAreaCorners[1] = new Vector3(8.5f, 3.75f, 0);
        gameAreaCorners[2] = new Vector3(8.5f,-3.75f, 0);
        gameAreaCorners[3] = new Vector3(-8.5f,-3.75f,0);

        centerLinePoints[0] = new Vector3(0,3.75f,0);
        centerLinePoints[1] = new Vector3(0,-3.75f,0);*/

        Instantiate(border);
        Instantiate(middleLine);

        Instantiate(leftPaddle);        
        Instantiate(rightPaddle);

        /*print(gameAreaCorners[0]);
        print(gameAreaCorners[1]);
        print(gameAreaCorners[2]);
        print(gameAreaCorners[3]);

        GameObject point1 = Instantiate(point, gameAreaCorners[0], Quaternion.identity);
        GameObject point2 = Instantiate(point, gameAreaCorners[1], Quaternion.identity);        
        GameObject point3 = Instantiate(point, gameAreaCorners[2], Quaternion.identity);
        GameObject point4 = Instantiate(point, gameAreaCorners[3], Quaternion.identity);
                

        point1.gameObject.name = "Top Left";        
        point2.gameObject.name = "Top Right";
        point3.gameObject.name = "Bottom Left";
        point4.gameObject.name = "Bottom Right";
        */

       

       /*LineRenderer borderLine = border.GetComponent<LineRenderer>();
       borderLine.positionCount = 4;
       borderLine.loop = true;
       borderLine.SetPositions(gameAreaCorners);       
       borderLine.material = borderMaterial;
       borderLine.startWidth = 0.2f;
       borderLine.endWidth = 0.2f;
       border.name = "Border";

       LineRenderer centerLine = middleLine.GetComponent<LineRenderer>();
       centerLine.SetPositions(centerLinePoints);
       centerLine.material = centerLineMaterial;
       centerLine.startWidth = 0.2f;
       centerLine.endWidth = 0.2f;
       middleLine.name = "Middle Line";*/

       
    }
}
