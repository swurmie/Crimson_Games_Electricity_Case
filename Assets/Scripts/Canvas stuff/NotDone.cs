using System.Collections;
using UnityEngine;

public class NotDone : MonoBehaviour
{
    public float delay = 3f;
    void OnEnable()
    {
        StartCoroutine(DisableAfterDelay());
    }

    IEnumerator DisableAfterDelay()
    {
        yield return new WaitForSeconds(delay);
        gameObject.SetActive(false);
    }
}