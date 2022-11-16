using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Collision_Detector : MonoBehaviour
{
    public bool b_playerTouchingFloor = true;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Floor")
        {
            b_playerTouchingFloor = false;
        }
    }
}
