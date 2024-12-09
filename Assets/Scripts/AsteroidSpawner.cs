using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject[] asteroidPrefabs;
    public float spawnInterval = 2f;  
    public float spawnRadius = 10f;  

    void Start()
    {
        InvokeRepeating("SpawnAsteroid", 0f, spawnInterval);
    }

    void SpawnAsteroid()
    {
        Vector2 spawnPosition = Random.insideUnitCircle * spawnRadius;
        int randomIndex = Random.Range(0, asteroidPrefabs.Length); 
        Instantiate(asteroidPrefabs[randomIndex], spawnPosition, Quaternion.identity);
    }
}
