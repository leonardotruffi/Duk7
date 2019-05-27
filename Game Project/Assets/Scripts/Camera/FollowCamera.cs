using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    public float smothSpeed = 0.125f;
    public Vector3 offset;


    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target);

    }
}