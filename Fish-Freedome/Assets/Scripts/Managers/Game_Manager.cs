using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    public bool b_enableControlls = false;
    public bool b_playerDied;

    public Finish_Line_Collider finish_Line_Collider;

    private void OnEnable()
    {
        b_playerDied = false;
        finish_Line_Collider = GameObject.Find("Finish_Line_Collider").GetComponent<Finish_Line_Collider>();
        StartCoroutine(Game_Start_Timer());
    }

    private void Update()
    {
        if (finish_Line_Collider.b_playerCrossedFinishLine)
        {
            Debug.Log("Player finished");
        }
        if (b_playerDied)
        {
            Debug.Log("Player Died");
        }
    }

    private IEnumerator Game_Start_Timer()
    {
        WaitForSeconds wait = new WaitForSeconds(3.0f);
        while (true)
        {
            yield return wait;
            b_enableControlls = true;
        }
    }

    

}
