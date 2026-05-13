using UnityEngine;

public class togglemovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


    private PlayerMovement PlayerMovement;

    // Update is called once per frame
    void Update()
    {
        playerMovement.enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
