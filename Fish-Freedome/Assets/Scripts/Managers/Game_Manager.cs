using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    public bool b_gameStarted = false;

    private void OnEnable()
    {
        StartCoroutine(Game_Start_Timer());
    }

    private IEnumerator Game_Start_Timer()
    {
        WaitForSeconds wait = new WaitForSeconds(3.0f);
        while (true)
        {
            yield return wait;
            b_gameStarted = true;
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
