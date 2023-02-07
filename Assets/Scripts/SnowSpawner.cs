using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowSpawner : MonoBehaviour
{
    public GameObject obstacle;
    public float spawntimerMax;
    public float spawntimerMin;
    private float timer;
    public float maxoffset;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Spawnobject();
            timer = Random.Range(spawntimerMin, spawntimerMax);
        }
    }
    void Spawnobject()
    {
        Vector2 spawnpos = new Vector2 (transform.position.x, Random.Range(-maxoffset, maxoffset));
        Instantiate(obstacle, spawnpos, Quaternion.identity);

    }
}
