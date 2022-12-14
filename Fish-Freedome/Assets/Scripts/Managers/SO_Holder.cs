using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SO_Holder : MonoBehaviour
{
    public Stage_Data[] data;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
