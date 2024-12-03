using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject FaroidPrefab;
    public float spawnInterval = 2f;  
    public float spawnRadius = 10f;  

    void Start()
    {
        InvokeRepeating("SpawnAsteroid", 0f, spawnInterval);
    }

    void SpawnAsteroid()
    {
        Vector2 spawnPosition = Random.insideUnitCircle * spawnRadius;
        Instantiate(FaroidPrefab, spawnPosition, Quaternion.identity);
    }
}
