using UnityEngine;
using TMPro;

public class ChatBubble : MonoBehaviour
{
    [SerializeField] TMP_Text usernameText;
    [SerializeField] TextMeshProUGUI messageText;

    public void Setup(string username, string message)
    {
        usernameText.text = username;
        messageText.text = message;
    }
}