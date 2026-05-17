using UnityEngine;

public class DisableScript : MonoBehaviour
{
    private PlayerMovement playerMovement; // lowercase, and use the actual type

    void Start()
    {
        playerMovement = GameObject.FindWithTag("Player").GetComponent<PlayerMovement>();
        playerMovement.enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void OnEnable()
    {
        if (playerMovement != null)
        {
            playerMovement.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    void OnDisable()
    {
        if (playerMovement != null)
        {
            playerMovement.enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}