using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowboarder : MonoBehaviour
{
    public Vector2 movementAxis;
    public float verticalspeed;
    public float speed = 2;
    public float max;
    Rigidbody2D rb2d; 
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(transform.position.y) >= max || Input.GetKeyDown("space"))
        {
            movementAxis *= -1;
        }
        rb2d.velocity = movementAxis * verticalspeed + Vector2.right * speed;
    }
}
