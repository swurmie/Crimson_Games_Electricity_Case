using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class playercollectibles : MonoBehaviour
{
    public float interacted = 0;
    private bool interacting;
    

    private void Update()
    {
        interacting = Keyboard.current.eKey.isPressed;
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Interactable") && interacting == true)
        {
            GameObject obj = collision.gameObject;
            obj.tag = "Untagged";
            obj.GetComponent<ObjectCanvas>().myCanvas.SetActive(true);

            Renderer rend = obj.GetComponent<Renderer>();
        if (rend != null)
        {
            Color color = rend.material.color;
            rend.material.color = new Color(color.r, color.g, color.b, 0.5f);
        }

            interacted += 1;
            Debug.Log(interacted);
        }
    }
}
