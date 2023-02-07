using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector2 movementAxis;
    public float horizontalSpeed;
    public float speed = 2;
    public float maxOffset = 10;
    Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(transform.position.x) >= maxOffset || Input.GetKeyDown("space"))
        {
            movementAxis *= -1;
        }
        rb2D.velocity = movementAxis * horizontalSpeed + Vector2.up * speed;
    }
}
