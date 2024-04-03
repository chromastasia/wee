using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
/*    public GameObject coinPrefab;
    public int maxCoins = 10; // Maximum number of coins allowed in the scene
    public Vector2 spawnAreaMin;
    public Vector2 spawnAreaMax;
    public float spawnInterval = 1f; // Interval between coin spawns in seconds

    private float timer;

    void Start()
    {
        timer = spawnInterval;
    }

    void Update()
    {
        // Spawn a coin every spawnInterval seconds
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            SpawnCoin();
            timer = spawnInterval;
        }

        // Check if there are more than maxCoins in the scene
        Coin[] coins = FindObjectsOfType<Coin>();
        if (coins.Length > maxCoins)
        {
            // Destroy a random coin
            int randomIndex = Random.Range(0, coins.Length);
            Destroy(coins[randomIndex].gameObject);
        }
    }

    void SpawnCoin()
    {
        // Instantiate a coin at a random position within the spawn area
        Vector2 spawnPosition = new Vector2(Random.Range(spawnAreaMin.x, spawnAreaMax.x), Random.Range(spawnAreaMin.y, spawnAreaMax.y));
        Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
    }*/
}
