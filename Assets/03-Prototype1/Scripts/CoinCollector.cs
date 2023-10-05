using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin")) 
        {
            UI.COIN_COLLECTED();
            Destroy(other.gameObject);
        }
    }
}
