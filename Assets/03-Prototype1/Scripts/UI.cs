using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    static private UI S;
    public Text uitLevel;
    public Text uitCoins;
    public Text uitLives; 
    public int coinsCollected;
    public int level;
    public int maxCoins = 10;
    public int totalCoinsCollected;
    public int lives = 20; 
    public GameObject gameOverCanvas;

    void Start()
    {
        S = this;
        level = 1;
        coinsCollected = 0;
        totalCoinsCollected = 0;
        UpdateGUI();
        gameOverCanvas.SetActive(false);
    }

    static public void COIN_COLLECTED()
    {
        S.coinsCollected++;
        S.totalCoinsCollected++;
        if (S.coinsCollected == S.maxCoins)
        {
            S.coinsCollected = 0;
            S.level++;
            S.RespawnCoins();
        }
        S.UpdateGUI();
    }

    public void UpdateGUI()
    {
        uitLevel.text = "Level: " + level;
        uitCoins.text = "Coins Collected: " + totalCoinsCollected;
        uitLives.text = "Lives: " + lives; 
    }

    public void RespawnCoins()
    {
        CoinSpawner coinSpawner = FindObjectOfType<CoinSpawner>();
        if (coinSpawner != null)
        {
            coinSpawner.SpawnCoins();
        }
    }

    public void DecreaseLives()
    {
        if (lives <= 0)
        {
            GameOver();
        }
        else
        {
            lives--;
        }
        UpdateGUI();
    }

    void GameOver()
    {
        gameOverCanvas.SetActive(true); 
        Time.timeScale = 0f;
    }
    
}
