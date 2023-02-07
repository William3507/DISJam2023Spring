using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyManagement : MonoBehaviour
{
    private float timer;
    public float spawnTimer = 15;

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
            Destroy(gameObject);
        }
    }
}
