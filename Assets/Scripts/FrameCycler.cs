using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameCycler : MonoBehaviour
{
    public Sprite[] frames;
    public float fps;
    private float frameTimer;
    private int currentFrame = 0;
    SpriteRenderer mySpriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        frameTimer = 1 / fps;
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (frameTimer <= 0)
        {
            if (currentFrame < frames.Length - 1)
            {
                currentFrame++;
            }
            else
            {
                currentFrame = 0;
            }    
            mySpriteRenderer.sprite = frames[currentFrame];
            frameTimer = 1 / fps;
        }
        frameTimer -= Time.deltaTime;
    }
}
