using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage_Selector_Manager : MonoBehaviour
{
    public Stage_Data[] stageData;

    public int totalAmountofCoins;

    private void Awake()
    {
        RundDownInfo();
    }

    void RundDownInfo()
    {
        for(int i = 0; i < stageData.Length; i++)
        {
            //Debug.Log(stageData[i].coinsCollected);
        }
    }
}
