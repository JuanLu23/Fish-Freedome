using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public Slider s_slider;

    public int i_maxAmountofCoins;
    public int i_currentAmountsofCoins;

    public RawImage[] ri_CollectedCoin;

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
}
