using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMovement : MonoBehaviour
{

    public GameObject backImage;
    private float timer;
    public float spawnTimer;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        timer = spawnTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            SpawnNewBackground();
            timer = spawnTimer;
        }

    }
    void SpawnNewBackground()
    {

        Vector3 spawnPosition = transform.position + Vector3.down * 20f;
        spawnPosition.z = 1;
        Instantiate(backImage, spawnPosition, Quaternion.identity);
    }
}

