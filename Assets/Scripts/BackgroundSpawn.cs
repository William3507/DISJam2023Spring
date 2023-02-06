using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSpawn : MonoBehaviour
{
    public Sprite[] backgrounds;
    public float timer;
    public GameObject background;
    private float currentTimer;
    private int currentBG = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTimer <= 0)
        {
            // Instantiate(background, (transform.position.x, transform.position.y + timer, 0));
        }
    }
}
