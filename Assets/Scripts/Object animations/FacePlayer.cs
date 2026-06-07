using UnityEngine;

public class FacePlayerAndBob : MonoBehaviour
{
    [Header("Bob Settings")]
    public float amplitude = 0.5f;
    public float frequency = 1f;

    [Header("Facing Settings")]
    private Transform player;
    private float lockedX = -90f;
    private float startY;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        startY = transform.position.y;
    }

    void Update()
    {
        // Bobbing
        float newY = startY + Mathf.Sin(Time.time * frequency) * amplitude;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);

        // Facing player
        Vector3 direction = player.position - transform.position;
        direction.y = 0f;

        if (direction != Vector3.zero)
        {
            float angle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + 90f;
            transform.rotation = Quaternion.Euler(lockedX, angle, 0f);
        }
    }
}