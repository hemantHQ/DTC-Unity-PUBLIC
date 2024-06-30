
using UnityEngine;

public class Main_Camera : MonoBehaviour
{
    public Transform cameraTransform;
    public Transform target;
    public float rotationSpeed = 0.5f;
    public float distance = 10.0f;
    public float yOffset = 3.0f;

    private Vector3 touchStart;
    private bool isRotating = false;

    private void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                if (touch.position.x >= Screen.width / 2)
                {
                    isRotating = true;
                    touchStart = touch.position;
                }
            }
            else if (touch.phase == TouchPhase.Moved && isRotating)
            {
                float deltaX = touch.position.x - touchStart.x;
                float deltaY = touch.position.y - touchStart.y;

                float rotationX = -deltaY * rotationSpeed;
                float rotationY = deltaX * rotationSpeed;

                transform.RotateAround(target.position, Vector3.up, rotationY);
                transform.RotateAround(target.position, transform.right, rotationX);

                touchStart = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                isRotating = false;
            }
        }
        Vector3 direction = -transform.forward;
        Vector3 desiredPosition = target.position + direction * distance + Vector3.up * yOffset;
        transform.position = desiredPosition;
    }
}
