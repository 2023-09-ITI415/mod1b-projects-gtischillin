using UnityEngine;

public class FallingObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnInterval = 2f;
    public float spawnRangeX = 16f;
    public float spawnHeightY = 10f;
    public int minObstacles = 1;
    public int maxObstacles = 4;

    void Start()
    {
        InvokeRepeating("SpawnObstacles", spawnInterval, spawnInterval);
    }

    void SpawnObstacles()
    {
        int numObstacles = Random.Range(minObstacles, maxObstacles + 1);

        for (int i = 0; i < numObstacles; i++)
        {
            float randomX = Random.Range(-spawnRangeX, spawnRangeX);
            Vector3 spawnPosition = new Vector3(randomX, spawnHeightY, 0f);

            GameObject obstacle = Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
            obstacle.AddComponent<FallingObstacle>(); // Add FallingObstacle component to spawned obstacles
        }
    }
}
