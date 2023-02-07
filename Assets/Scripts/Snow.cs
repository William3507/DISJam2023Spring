using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snow : MonoBehaviour
{
    public Transform player;
    public float offsetX;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (pos.x - player.position.x <= offsetX)
        {
            pos.x = player.position.x + offsetX;
        }
        transform.position = pos;
    }
}
