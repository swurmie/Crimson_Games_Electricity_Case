using UnityEngine;

public class MenuTracker : MonoBehaviour
{
    void OnEnable()  => Pausing.openMenus++;
    void OnDisable() => Pausing.openMenus--;
}