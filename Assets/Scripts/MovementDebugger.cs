using UnityEngine;

public class MovementDebugger : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private bool lastEnabled;

    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        lastEnabled = playerMovement.enabled;
    }

    void Update()
    {
        if (playerMovement.enabled != lastEnabled)
        {
            Debug.Log($"PlayerMovement changed to: {playerMovement.enabled}");
            lastEnabled = playerMovement.enabled;
        }
    }
}