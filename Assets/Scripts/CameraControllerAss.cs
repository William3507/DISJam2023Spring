using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerAss : MonoBehaviour
{
    public Transform player;
    private float offsetY = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (pos.y - player.position.y <= offsetY)
        {
            pos.y = player.position.y + offsetY;
        }
        transform.position = pos;
    }
}
