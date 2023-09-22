using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // This method is called when a collision occurs.
        // You can implement your collision response logic here.
        Debug.Log("Collision occurred with: " + collision.gameObject.name);
    }
}
