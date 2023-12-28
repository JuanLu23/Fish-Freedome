using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_Player_Collider : MonoBehaviour
{

    private New_Player_Stats playerStats;

    private void Start()
    {
        playerStats = New_Player_Stats.Instance;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Floor")
        {
            Debug.Log("Is on floor");
            playerStats.playerIsOnFloor = true;
        }
    }
}
