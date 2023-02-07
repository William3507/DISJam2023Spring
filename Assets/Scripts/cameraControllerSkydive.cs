using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControllerSkydive : MonoBehaviour
{

    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.y <= 0)
        {
            Vector3 pos = transform.position;
            pos.y = player.position.y;
            transform.position = pos;
        }

    }
}
