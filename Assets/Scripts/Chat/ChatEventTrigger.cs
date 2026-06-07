using UnityEngine;
using System.Collections;

public class ChatEventTrigger : MonoBehaviour
{
    [SerializeField] StreamChatManager chatManager;
    [SerializeField] string categoryTag;

    void OnEnable()
    {
        StartCoroutine(DelayedSwitch());
    }

    IEnumerator DelayedSwitch()
    {
        yield return new WaitForSeconds(2f);
        chatManager.SwitchCategory(categoryTag);
    }

    void OnDisable()
    {
        StopAllCoroutines();
        chatManager.SwitchCategory("generic");
    }
}