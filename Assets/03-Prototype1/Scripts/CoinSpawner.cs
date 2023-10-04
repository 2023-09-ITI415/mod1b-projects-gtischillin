using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;

    void Start()
    {
        SpawnCoins();
    }

    void SpawnCoins()
    {
        for (int i = 0; i < 10; i++) // Change 10 to the desired number of coins
        {
            float xPos = Random.Range(-16f, 16f); // x range: -16 to 16
            float yPos = Random.Range(-8f, -1.5f); // y range: -8 to -1.5

            Instantiate(coinPrefab, new Vector3(xPos, yPos, 0), Quaternion.identity);
        }
    }
}
