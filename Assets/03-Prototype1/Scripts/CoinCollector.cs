using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin")) // Assuming you've tagged your coins as "Coin"
        {
            UI.COIN_COLLECTED();
            Destroy(other.gameObject); // Destroy the coin
        }
    }
}
