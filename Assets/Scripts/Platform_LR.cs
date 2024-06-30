using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_LR : MonoBehaviour
{
    public float minX; // The leftmost position of the platform
    public float maxX; // The rightmost position of the platform
    public float speed; // The speed at which the platform moves

    private bool movingRight = true; // Indicates if the platform is moving right or left

    private void Update()
    {
        // Check if the platform has reached either the min or max X position
        if (transform.position.x >= maxX)
            movingRight = false;
        else if (transform.position.x <= minX)
            movingRight = true;

        // Move the platform right or left
        if (movingRight)
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        else
            transform.Translate(-Vector3.right * speed * Time.deltaTime);
    }
}
