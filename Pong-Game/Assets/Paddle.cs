using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        other.transform.Rotate(new Vector3(0,0,45));
    }
}
