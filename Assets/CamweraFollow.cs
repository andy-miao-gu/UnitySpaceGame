using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;      // The object to follow
    public Vector3 offset = new Vector3(0, 5, -20); // Offset from the target
    public float smoothSpeed = 0.125f; // Smoothing factor

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target);
    }
}