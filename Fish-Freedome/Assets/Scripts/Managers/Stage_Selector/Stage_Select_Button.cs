using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stage_Select_Button : MonoBehaviour
{

    [SerializeField] private Stage_Selector_Manager stageManager;
    public RawImage[] ri_stageCardCollectedCoin;
    public GameObject go_stage_Lock;

    public int i_levelNumber;

    public int amountOfCoinToUnlock;
    private int totalAmountOfCoins;

    int i_currentAmountsofCoins;// <- Esta variable tiene que ser la que esta conectada en el save system

    public void Start()
    {
        stageManager = GameObject.FindGameObjectWithTag("Stage Select Manager").GetComponent<Stage_Selector_Manager>();
        Unlock_Button();
        Activate_Coin_In_UI();
    }

    public void Unlock_Button()
    {
        if (totalAmountOfCoins >= amountOfCoinToUnlock)
        {
            go_stage_Lock.SetActive(false);
        }
    }

    public void Activate_Coin_In_UI()
    {
        for(int i = 0; i < (stageManager.stageData[i_levelNumber - 1].coinsCollected); i++)
        {
            ri_stageCardCollectedCoin[i].gameObject.SetActive(true);
        }
        /*
        switch (stageManager.stageData[i_levelNumber - 1].coinsCollected)
        {
            case 1:
                ri_stageCardCollectedCoin[0].gameObject.SetActive(true);
                break;
            case 2:
                ri_stageCardCollectedCoin[0].gameObject.SetActive(true);
                ri_stageCardCollectedCoin[1].gameObject.SetActive(true);
                break;
            case 3:
                ri_stageCardCollectedCoin[0].gameObject.SetActive(true);
                ri_stageCardCollectedCoin[1].gameObject.SetActive(true);
                ri_stageCardCollectedCoin[2].gameObject.SetActive(true);
                break;
        }*/
    }

    public void StageOne()
    {
        SceneManager.LoadScene("Level_01_Scene");
    }

    public void StageTwo()
    {
        SceneManager.LoadScene("Level_02_Scene");
    }

    public void StageThree()
    {
        SceneManager.LoadScene("Level_03_Scene");
    }

    public void StageTutorial()
    {
        SceneManager.LoadScene("Tutorial_Scene");
    }
}
