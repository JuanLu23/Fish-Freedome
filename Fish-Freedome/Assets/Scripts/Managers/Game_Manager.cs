using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    private Player_Stats_Controller _playerStatsController;


    private void Start()
    {
        _playerStatsController = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Stats_Controller>();
        StartCoroutine(Game_Start_Timer());
    }

    private IEnumerator Game_Start_Timer()
    {
        WaitForSeconds wait = new WaitForSeconds(3.0f);
        while (true)
        {
            yield return wait;
            _playerStatsController.b_gameStarted = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("GAME WON");
        }
    }

}
