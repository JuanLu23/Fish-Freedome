using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    private Game_Manager gameManager;

    public Slider s_slider;

    public Stage_Data s_data;

    // COMENTARIO PARA IAN
    // Caballero aqui es donde se esta sacando la variable de cuantas monedas el pleyer recolecto en el nivel
    public int i_currentAmountsofCoins; // <--- Esta es la variable, si la cambias avisame por que tambien hay que cambiarla en el codigo "Stage_Selec_Button"

    public RawImage[] ri_CollectedCoin;

    private void Awake()
    {
        gameManager = GameObject.Find("Game_Manager").GetComponent<Game_Manager>();
        gameManager.recordCoinsObtained.AddListener(Save_in_Data_Coins_Obtained);
        i_currentAmountsofCoins = 0;
    }

    public void SetMaxSliderValue(float _health)
    {
        s_slider.maxValue = _health;
        s_slider.value = _health;
    }

    public void SetSliderValue(float _health)
    {
        s_slider.value = _health;
    }

    public void Activate_Coin_In_UI()
    {
        switch (i_currentAmountsofCoins)
        {
            case 1:
                ri_CollectedCoin[0].gameObject.SetActive(true);
                break;
            case 2:
                ri_CollectedCoin[1].gameObject.SetActive(true);
                break;
            case 3:
                ri_CollectedCoin[2].gameObject.SetActive(true);
                break;
        }
    }

    private void Save_in_Data_Coins_Obtained()
    {
        if (i_currentAmountsofCoins > s_data.coinsCollected)
        {
            s_data.coinsCollected = i_currentAmountsofCoins;
        }
        
    }

    /*public object SaveState()
    {
        return new SaveData()
        {
            i_currentAmountsofCoins = this.i_currentAmountsofCoins
        };
    }

    public void LoadState(object state)
    {
        var saveData = (SaveData)state;
        i_currentAmountsofCoins = saveData.i_currentAmountsofCoins;
    }

    [Serializable]
    private struct SaveData
    {
        public int i_currentAmountsofCoins;
    }*/
}
