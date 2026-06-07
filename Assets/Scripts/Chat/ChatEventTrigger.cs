using UnityEngine;

public class ChatEventTrigger : MonoBehaviour
{
    [SerializeField] StreamChatManager chatManager;
    [SerializeField] string categoryTag;

    void OnEnable()
    {
        chatManager.SwitchCategory(categoryTag);
    }

    void OnDisable()
    {
        chatManager.SwitchCategory("generic");
    }
}