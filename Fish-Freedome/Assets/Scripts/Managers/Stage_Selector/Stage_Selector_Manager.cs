using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage_Selector_Manager : MonoBehaviour, ISavable
{
    public Stage_Data[] stageData;

    public int totalAmountofCoins;

    public int coinscollected1;
    public int coinscollected2;
    public int coinscollected3;


    private void Start()
    {
        RundDownInfo();
        coinscollected1 = stageData[0].coinsCollected;
        coinscollected2 = stageData[1].coinsCollected;
        coinscollected3 = stageData[2].coinsCollected;
    }

    public void Update()
    {
    }

    void RundDownInfo()
    {
        for (int i = 0; i < stageData.Length; i++)
        {
            //Debug.Log(stageData[i].coinsCollected);
        }
    }

    public void UpdateDataValues()
    {
        stageData[0].coinsCollected = coinscollected1;
        stageData[1].coinsCollected = coinscollected2;
        stageData[2].coinsCollected = coinscollected3;
        Debug.Log("obamium");
    }

    public object SaveState()
    {
        return new SaveData()
        {
            coinscollected1 = coinscollected1,
            coinscollected2 = coinscollected2,
            coinscollected3 = coinscollected3
        };
    }



    public void LoadState(object state)
    {
        var saveData = (SaveData)state;
        coinscollected1 = saveData.coinscollected1;
        coinscollected2 = saveData.coinscollected2;
        coinscollected3 = saveData.coinscollected3;
        Debug.Log("obamium");
    }

    [Serializable]
    private struct SaveData
    {
        public int coinscollected1;
        public int coinscollected2;
        public int coinscollected3;
    }
}