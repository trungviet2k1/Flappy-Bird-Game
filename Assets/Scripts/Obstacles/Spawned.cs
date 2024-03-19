using System.Collections;
using UnityEngine;

public class Spawned : MonoBehaviour
{
    public GameObject[] ObstaclePrefabs;
    public bool Spawn;
    public float spawnTimer;

    void Update()
    {
        if (Spawn)
        {
            Spawn = false;
            SpawnPoint();
        }
    }

    public void SpawnPoint()
    {
        int ots = Random.Range(0, ObstaclePrefabs.Length);
        Instantiate(ObstaclePrefabs[ots], transform.position, transform.rotation);
        StartCoroutine(SpawnDelay());
    }

    IEnumerator SpawnDelay()
    {
        yield return new WaitForSeconds(spawnTimer);
        Spawn = true;
    }
}
