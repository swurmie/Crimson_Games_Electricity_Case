using UnityEngine;

public class EnableStreamChatOnDisable : MonoBehaviour
{
    public GameObject StreamChatManager;

    void OnDisable()
    {
        StreamChatManager.SetActive(true);
    }
}
