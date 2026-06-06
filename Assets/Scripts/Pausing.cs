using UnityEngine;
using UnityEngine.InputSystem;

public class Pausing : MonoBehaviour
{
    private PlayerMovement playerMovement;
    [SerializeField] bool Pause = false;
    public GameObject Pause_screen;
    public bool canvasmenu;
    public static int openMenus = 0;

    private void Start()
    {
        playerMovement = GameObject.FindWithTag("Player").GetComponent<PlayerMovement>();
    }

    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame && openMenus == 0)
        {
            Pause = !Pause;
        }

        if (!Pause && !canvasmenu)
        {
            Pause_screen.SetActive(false);
            if (playerMovement != null)
            {
                playerMovement.enabled = true;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
        else
        {
            Pause_screen.SetActive(Pause); 
            if (playerMovement != null)
            {
                playerMovement.enabled = false;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
    }

    public void PauseToggle(bool paused)
    {
        Pause = false;
    }
}