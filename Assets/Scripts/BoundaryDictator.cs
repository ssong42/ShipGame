using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryDictator : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float minX = -10f;
    public float maxX = 10f;
    public float minY = -10f;
    public float maxY = 10f;

    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 velocity = rb.velocity;

        // Check if the sprite hits the left or right boundaries
        if ((transform.position.x < minX && velocity.x < 0) || (transform.position.x > maxX && velocity.x > 0))
        {
            // Reflect the velocity horizontally to create a ricochet effect
            velocity.x = -velocity.x;
            rb.velocity = velocity;
        }

        // Check if the sprite hits the top or bottom boundaries
        if ((transform.position.y < minY && velocity.y < 0) || (transform.position.y > maxY && velocity.y > 0))
        {
            // Reflect the velocity vertically to create a ricochet effect
            velocity.y = -velocity.y;
            rb.velocity = velocity;
        }
    }
}
