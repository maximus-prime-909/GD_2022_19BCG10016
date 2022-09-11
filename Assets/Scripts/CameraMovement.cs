using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform playerTransform;
    Vector3 offset = new Vector3(0, 35, -60);
    [SerializeField]
    [Range(2, 10)]
    int smoothening = 3;

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        Vector3 targetPosition = playerTransform.position + offset;
        Vector3 smoothTransform = Vector3.Lerp(transform.position, targetPosition, smoothening * Time.fixedDeltaTime);
        transform.position = smoothTransform;
    }
}
