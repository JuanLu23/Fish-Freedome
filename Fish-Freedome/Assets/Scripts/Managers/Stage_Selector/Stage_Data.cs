using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Level_Data", menuName = "Levels")]
public class Stage_Data : ScriptableObject, ISavable
{
    public int coinsCollected;

    private Stage_Data()
    {
        //coinsCollected = 0;
    }

    public object SaveState()
    {
        return new SaveData()
        {
            coinsCollected = this.coinsCollected
        };
    }

    public void LoadState(object state)
    {
        var saveData = (SaveData)state;
        coinsCollected = saveData.coinsCollected;
    }

    [Serializable]
    private struct SaveData
    {
        public int coinsCollected;
    }
}
