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

    public void SpawnCoins()
    {
        for (int i = 0; i < 10; i++) 
        {
            float xPos = Random.Range(-16f, 16f); 
            float yPos = Random.Range(-8f, -1.5f); 

            Instantiate(coinPrefab, new Vector3(xPos, yPos, 0), Quaternion.identity);
        }
    }
}
