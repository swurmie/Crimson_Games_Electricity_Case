using UnityEngine;

public class ToggleObject : MonoBehaviour
{
    public GameObject target;
    public KeyCode key = KeyCode.T;

    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            target.SetActive(!target.activeSelf);
        }
    }
}