using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this value to control movement speed
    public float minX = -5f; // Define the minimum X position
    public float maxX = 5f;  // Define the maximum X position
    public float minY = -5f; // Define the minimum Y position
    public float maxY = 5f;  // Define the maximum Y position

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Vector3 newPosition = transform.position; // Initialize newPosition

        // // Get input for horizontal movement
        // float horizontalInput = Input.GetAxis("Horizontal");
        // float verticalInput = Input.GetAxis("Vertical");

        // // Calculate the new position
        // newPosition += new Vector3(horizontalInput, verticalInput, 0) * moveSpeed * Time.deltaTime;

        // // Clamp the position within boundaries
        // newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
        // newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);

        // // Update the position
        // transform.position = newPosition;


        // Get input for horizontal movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the new velocity based on input
        Vector2 movement = new Vector2(horizontalInput * moveSpeed, verticalInput * moveSpeed);
        
        rb.velocity = movement;
    }
}
