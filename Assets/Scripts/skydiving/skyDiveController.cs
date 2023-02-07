using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyDiveController : MonoBehaviour
{
    public SpriteRenderer mySpriteRenderer;
    public float animationFPS;
    public Sprite[] spriteList = new Sprite[2];
    float frameTimer;
    int currentFrame;
    private Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        rb2D = GetComponent<Rigidbody2D>(); //Checks object where script is attached

        frameTimer = 0;
        currentFrame = 0;
    }

    // Update is called once per frame
    void Update()
    {

        frameTimer -= Time.deltaTime;
        if (frameTimer <= 0)
        {
            mySpriteRenderer.sprite = spriteList[currentFrame];
            frameTimer = 1 / animationFPS;
            currentFrame++;
            if (currentFrame >= spriteList.Length)
            {
                currentFrame = 0;
            }
        }


        Vector2 vel = rb2D.velocity;

        vel.y = -5;

        //Change direction when space is pressed
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

            if (vel.x > 0)
            {
                mySpriteRenderer.flipX = false;
            }
            else
            {
                mySpriteRenderer.flipX = true;
            }
        }

        //keep from going out of bounds
        if (transform.position.x >= 9)
        {
            vel.x = -4;
            mySpriteRenderer.flipX = true;

        }
        if (transform.position.x <= -9)
        {
            vel.x = 4;
            mySpriteRenderer.flipX = false;
        }
        rb2D.velocity = vel;


    }
}
