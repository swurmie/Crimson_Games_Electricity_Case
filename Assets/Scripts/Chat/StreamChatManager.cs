using UnityEngine;
using System.Collections;

public class StreamChatManager : MonoBehaviour
{
    [SerializeField] GameObject chatBubblePrefab;
    [SerializeField] Transform chatContent;
    [SerializeField] ChatMessagePool messagePool;

    void Start()
    {
        StartCoroutine(ChatLoop());
    }

    IEnumerator ChatLoop()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0.5f, 2f));
            SpawnMessage("generic");
        }
    }

    public void TriggerEvent(string eventTag)
    {
        SpawnMessage(eventTag);
    }

    void SpawnMessage(string eventTag)
    {
        string text = messagePool.GetRandom(eventTag);
        string user = messagePool.GetRandomUsername();

        GameObject obj = Instantiate(chatBubblePrefab, chatContent);

        ChatBubble bubble = obj.GetComponent<ChatBubble>();
        bubble.Setup(user, text);

        if (chatContent.childCount > 5)
            Destroy(chatContent.GetChild(0).gameObject);
    }
}