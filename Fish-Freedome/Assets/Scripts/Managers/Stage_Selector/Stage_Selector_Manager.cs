using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage_Selector_Manager : MonoBehaviour
{
    public Stage_Data[] stageData;

    public int totalAmountofCoins;

    private void Start()
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

    /*public object SaveState()
    {
        return new SaveData()
        {
            stageData = this.stageData
        };
    }

    public void LoadState(object state)
    {
        var saveData = (SaveData)state;
        stageData = saveData.stageData;
    }

    [Serializable]
    private struct SaveData
    {
        public Stage_Data[] stageData;
    }*/
}
