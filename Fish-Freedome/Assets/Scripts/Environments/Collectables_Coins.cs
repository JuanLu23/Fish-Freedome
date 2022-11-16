using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Collectables_Coins : MonoBehaviour
{
    public UnityEvent ue_coinCollected;

    private void OnTriggerEnter(Collider _collider)
    {
        if(_collider.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }

   
}
