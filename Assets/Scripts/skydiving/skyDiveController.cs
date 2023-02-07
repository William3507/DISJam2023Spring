using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skyDiveController : MonoBehaviour
{
    public SpriteRenderer mySpriteRenderer;
    public float animationFPS;
    public Sprite[] spriteList = new Sprite[2];
    float frameTimer;
    int currentFrame;
    private Rigidbody2D rb2D;
    public Sprite deathSprite;
    public GameObject forestBackground;
    public bool isHit = false;
    public float deathTimer = 4;
    bool hasSpawned = false;
    public string nextScene;


    // Start is called before the first frame update
    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        rb2D = GetComponent<Rigidbody2D>(); //Checks object where script is attached

        frameTimer = 0;
        currentFrame = 0;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        isHit = true;

        if (col.gameObject.CompareTag("Obstacle"))
        {
            onDeath(mySpriteRenderer, deathSprite);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vel = rb2D.velocity;

        if (!isHit)
        {
            changeCostume();

            //Controlling downward movement

            vel.y = -5;


            //Change direction when space is pressed
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (vel.x == 0)
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
        else
        {
            //Get Sprite back to center

            mySpriteRenderer.sprite = deathSprite;


            if (transform.position.x < -1)
            {
                vel.x = 4;
            }
            else if(transform.position.x > 1)
            {
                vel.x = -4;
            }
            else
            {
                vel.x = 0;
               
            }


            if (vel.x == 0 && hasSpawned == false)
            {
                Vector3 spawnPosition = transform.position;
                spawnPosition += new Vector3(0, -20, 0.5f);
                // the Instatiate function creates a new GameObject copy (clone) from a Prefab at a specific location and orientation.
                Instantiate(forestBackground, spawnPosition, Quaternion.identity);

                hasSpawned = true;
            }


            if (hasSpawned)
            {
                deathTimer -= Time.deltaTime;
                if(deathTimer <= 0)
                {
                    vel.y = 0;

                    SceneManager.LoadScene(nextScene, LoadSceneMode.Single);
                }
            }

            rb2D.velocity = vel;

        }

    }

    public void changeCostume()
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
    }

    void onDeath(SpriteRenderer mySpriteRenderer, Sprite deathSprite)
    {
        mySpriteRenderer.sprite = deathSprite;

        spriteList[0] = deathSprite;
        spriteList[1] = deathSprite;
        spriteList[2] = deathSprite;


    }
}
