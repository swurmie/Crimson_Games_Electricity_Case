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
            //obj.GetComponent<Collider>().enabled = false;

            Renderer rend = obj.GetComponent<Renderer>();
        if (rend != null)
        {
            Material mat = rend.material;
            mat.SetFloat("_Mode", 3);
            mat.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
            mat.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
            mat.SetInt("_ZWrite", 0);
            mat.DisableKeyword("_ALPHATEST_ON");
            mat.EnableKeyword("_ALPHABLEND_ON");
            mat.DisableKeyword("_ALPHAPREMULTIPLY_ON");
            mat.renderQueue = 3000;

            Color color = mat.color;
            color.a = 0.3f;
            mat.color = color;
        }

            interacted += 1;
            Debug.Log(interacted);
        }
    }
}
