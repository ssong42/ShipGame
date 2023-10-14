using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    public float moveSpeed = 10f;
    public float maxSpeed = 500f;
    public float acceleration = 20f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Get input for horizontal and vertical movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the new velocity based on input and acceleration
        Vector2 inputDirection = new Vector2(horizontalInput, verticalInput).normalized;
        Vector2 targetVelocity = inputDirection * maxSpeed;

        // Accelerate toward the target velocity
        rb.velocity = Vector2.MoveTowards(rb.velocity, targetVelocity, acceleration * Time.deltaTime);
    }
}
