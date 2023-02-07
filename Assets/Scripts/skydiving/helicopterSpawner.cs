using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helicopterSpawner : MonoBehaviour
{
    public float spawnWidth = 1;
    public float spawnRate = 1;
    public GameObject helicopter;

    private float lastSpawnTime = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (lastSpawnTime + 1 / spawnRate < Time.time)
        {
            lastSpawnTime = Time.time;
            Vector3 spawnPosition = transform.position;
            spawnPosition += new Vector3(0, Random.Range(-spawnWidth, spawnWidth), 0);
            // the Instatiate function creates a new GameObject copy (clone) from a Prefab at a specific location and orientation.
            Instantiate(helicopter, spawnPosition, Quaternion.identity);
        }
    }
}
