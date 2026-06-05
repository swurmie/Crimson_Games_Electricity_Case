using UnityEngine;

public class DeleteInteractableMarker : MonoBehaviour
{
    public GameObject ObjectMarker;

    void Update()
    {
        if (!gameObject.CompareTag("Interactable"))
        {
            ObjectMarker.SetActive(false);
        }
    }
}
