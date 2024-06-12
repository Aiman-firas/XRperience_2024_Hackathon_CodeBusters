using System.Collections;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn; // The prefab to be spawned
    public float spawnInterval = 1f; // Time interval between spawns
    public Vector3 spawnPosition = Vector3.zero; // Position to spawn objects
    public Vector3 spawnArea = new Vector3(10, 10, 10); // Area within which objects will be spawned

    void Start()
    {
        StartCoroutine(SpawnObjectsContinuously());
    }

    IEnumerator SpawnObjectsContinuously()
    {
        while (true)
        {
            SpawnObject();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void SpawnObject()
    {
        // Calculate a random position within the spawn area
        Vector3 randomPosition = new Vector3(
            Random.Range(-spawnArea.x / 2, spawnArea.x / 2),
            Random.Range(-spawnArea.y / 2, spawnArea.y / 2),
            Random.Range(-spawnArea.z / 2, spawnArea.z / 2)
        );

        // Instantiate the object at the calculated position
        Instantiate(objectToSpawn, spawnPosition + randomPosition, Quaternion.identity);
    }
}
