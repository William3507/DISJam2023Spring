using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Vector2 movementAxis;
    public float horizontalSpeed;
    public float speed = 2;
    public float maxOffset = 10;
    public string obstacleTag = "obstacle";
    public string nextScene;
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

    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.CompareTag(obstacleTag))
        {
            SceneManager.LoadScene(nextScene, LoadSceneMode.Single);
        }
    }
}
