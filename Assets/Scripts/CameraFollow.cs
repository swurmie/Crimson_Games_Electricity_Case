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

        // Calculate position behind the player based on where THEY are facing
        Vector3 desiredPosition = target.position
                                - target.forward * distance
                                + Vector3.up * height;

        // Smoothly move to that position
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        // Look at the player
        transform.LookAt(target.position + Vector3.up * (height * 0.5f));
    }
}