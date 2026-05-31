using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform target;
    public float distance = 15f;
    public float height = 10f;
    public float smoothSpeed = 50f;

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position
                                - target.forward * distance
                                + Vector3.up * height;

        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        transform.LookAt(target.position + Vector3.up * (height * 0.5f));
    }
}