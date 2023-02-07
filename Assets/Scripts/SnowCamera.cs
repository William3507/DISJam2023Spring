using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowCamera : MonoBehaviour
{
    public GameObject backImage;
    private float timer;
    public float distance;
    public float spawnTimer;
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            SpawnNew();
            timer = spawnTimer;
        }
    }
    void SpawnNew()
    {
        Vector3 spawnPos = transform.position + Vector3.right * distance;
        spawnPos.z = 1;
        Instantiate(backImage, spawnPos, Quaternion.identity);
    }
}
