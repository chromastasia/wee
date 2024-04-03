using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Adjust the offset if needed
    private Camera mainCamera;
    private float minX, maxX, minY, maxY;

    void Start()
    {
        mainCamera = Camera.main;

        // Calculate screen bounds based on camera's viewport
        Vector2 screenBounds = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, mainCamera.transform.position.z));

        // Set the min and max X and Y values for the crosshair position
        minX = -screenBounds.x;
        maxX = screenBounds.x;
        minY = -screenBounds.y;
        maxY = screenBounds.y;

    }

    void Update()
    {
        // Get the mouse position
        Vector3 mousePosition = Input.mousePosition;
      

        // Convert the mouse position from screen space to world space
        Vector3 worldPosition = mainCamera.ScreenToWorldPoint(mousePosition);
        worldPosition.z = 0f; // Ensure crosshair stays in the 2D plane

        // Clamp the crosshair position to the screen boundaries
        Vector3 clampedPosition = worldPosition;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, minX, maxX);
        clampedPosition.y = Mathf.Clamp(clampedPosition.y, minY, maxY);


        // Update the crosshair position
        transform.position = clampedPosition;

     
        // Check if mouse button is clicked
        if (Input.GetMouseButtonDown(0)) // Change to appropriate mouse button if needed
        {
              // Cast a ray from the mouse position
              RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

              // Check if the raycast hits a coin
              if (hit.collider != null && hit.collider.CompareTag("coin"))
              {
               // Destroy the coin
               Destroy(hit.collider.gameObject);
              }

              if (hit.collider != null)
              {
                Debug.Log("Hit object tag: " + hit.collider.tag);
                Debug.Log("Hit object name: " + hit.collider.gameObject.name);
              }

        }
    }
}
