using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyDiveController : MonoBehaviour
{
    private Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>(); //Checks object where script is attached
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 vel = rb2D.velocity;

        vel.y = -5;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(vel.x == 0)
            {
                vel.x = 4;
            }
            else
            {
                vel.x *= -1;
            }
        }

        rb2D.velocity = vel;


    }
}
