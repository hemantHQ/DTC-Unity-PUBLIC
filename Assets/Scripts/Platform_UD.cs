using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Platform_UD : MonoBehaviour
{
    public float minHeight;
    public float maxHeight;
    public float speed;
    public Transform referencePoint;

    private bool movingUp = true;

    private void Update()
    {
        if (transform.position.y >= maxHeight)
            movingUp = false;
        else if (transform.position.y <= minHeight)
            movingUp = true;

        if (movingUp)
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        else
            transform.Translate(-Vector3.up * speed * Time.deltaTime);

        referencePoint.position = new Vector3(referencePoint.position.x, transform.position.y, referencePoint.position.z);
    }
}