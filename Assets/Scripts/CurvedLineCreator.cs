using System.Collections.Generic;
using UnityEngine;

public class CurvedLineCreator : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public float pointSpacing = 0.2f; // Adjust this value to control point spacing
    private List<Vector3> points = new List<Vector3>();

    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Get the mouse click position
            Vector3 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            clickPosition.z = 0; // Set the Z-coordinate to 0

            // Add the click position to the points list
            points.Add(clickPosition);

            // Update the Line Renderer with the new points
            UpdateLineRenderer();
        }
    }

    private void UpdateLineRenderer()
    {
        // Clear the existing points
        lineRenderer.positionCount = 0;

        // Interpolate points along the path for smoothness
        List<Vector3> interpolatedPoints = new List<Vector3>();
        for (int i = 0; i < points.Count - 1; i++)
        {
            Vector3 start = points[i];
            Vector3 end = points[i + 1];

            float distance = Vector3.Distance(start, end);
            int segments = Mathf.CeilToInt(distance / pointSpacing);

            for (int j = 0; j <= segments; j++)
            {
                float t = j / (float)segments;
                interpolatedPoints.Add(Vector3.Lerp(start, end, t));
            }
        }

        // Set the positions for the Line Renderer
        lineRenderer.positionCount = interpolatedPoints.Count;
        lineRenderer.SetPositions(interpolatedPoints.ToArray());
    }
}
