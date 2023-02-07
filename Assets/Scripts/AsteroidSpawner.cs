using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject[] obstacles;
    public float spawnTimerMax;
    public float spawnTimerMin;
    private float timer;
    public float maxOffset = 9;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            SpawnObstacle();
            timer = Random.Range(spawnTimerMin, spawnTimerMax);
        }
    }

    void SpawnObstacle()
    {
        GameObject obstacle = obstacles[Random.Range(0, obstacles.Length)];
        Vector2 spawnPosition = new Vector2 (Random.Range(-maxOffset, maxOffset), transform.position.y);
        Instantiate(obstacle, spawnPosition, Quaternion.identity);
    }
}
