using System.Collections;
using UnityEngine;

public class DroidSpawner : MonoBehaviour
{
    public GameObject obj; // Prefab to be spawned
    public Vector3 spawnPosition = new Vector3(0, -0.87f, 40.18f); // Position to spawn objects
    public bool spawningBool = true;
    public float spawnTime = 1f; // Time interval between spawns

    void Start()
    {
        StartCoroutine(Spawning());
    }

    IEnumerator Spawning()
    {
        while (spawningBool)
        {
            yield return new WaitForSeconds(spawnTime);
            // Define the rotation with y = -180
            Quaternion spawnRotation = Quaternion.Euler(0, -180, 0);
            Instantiate(obj, spawnPosition, spawnRotation);
        }
    }
}
