using UnityEngine;

public class DisableScript : MonoBehaviour
{
    private PlayerMovement playerMovement;
    static Pausing canvasmenu;

    void Awake()
    {
        playerMovement = GameObject.FindWithTag("Player").GetComponent<PlayerMovement>();
        canvasmenu = GameObject.FindWithTag("Player").GetComponent<Pausing>();
    }

    void Start()
    {
        playerMovement.enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        canvasmenu.canvasmenu = true;
    }

    void OnEnable()
    {
        if (playerMovement != null)
        {
            playerMovement.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            canvasmenu.canvasmenu = true;
        }
    }

    void OnDisable()
    {
        if (playerMovement != null)
        {
            playerMovement.enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            canvasmenu.canvasmenu = false;
        }
    }
}