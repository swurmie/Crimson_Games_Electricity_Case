using UnityEngine;
using UnityEngine.InputSystem;

public class playercollectibles : MonoBehaviour
{
    public float interacted = 0;
    public float interactRange = 3f;

    private void Update()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            Collider[] nearby = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider col in nearby)
            {
                if (col.CompareTag("Interactable"))
                {
                    GameObject obj = col.gameObject;
                    obj.tag = "Untagged";
                    obj.GetComponent<ObjectCanvas>().myCanvas.SetActive(true);

                    Renderer[] renderers = obj.GetComponentsInChildren<Renderer>();
                    foreach (Renderer childRend in renderers)
                    {
                        Material mat = childRend.material;
                        mat.SetFloat("_Surface", 1f);
                        mat.SetOverrideTag("RenderType", "Transparent");
                        mat.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
                        mat.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
                        mat.SetInt("_ZWrite", 0);
                        mat.EnableKeyword("_SURFACE_TYPE_TRANSPARENT");
                        mat.EnableKeyword("_ALPHAPREMULTIPLY_ON");
                        mat.SetShaderPassEnabled("ShadowCaster", false);
                        mat.renderQueue = 3000;

                        Color color = childRend.material.color;
                        childRend.material.color = new Color(color.r, color.g, color.b, 0.3f);
                    }

                    interacted += 1;
                    Debug.Log(interacted);
                }
            }
        }
    }
}