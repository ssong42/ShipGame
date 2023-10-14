using UnityEngine;
public class CameraFollow : MonoBehaviour
{
    public Transform target;  // Reference to the object the camera should follow
    public Vector3 offset;   // Offset position of the camera relative to the target

    void LateUpdate()
    {
        if (target != null)
        {
            // Update the camera's position to follow the target
            transform.position = target.position + offset;
        }
    }
}