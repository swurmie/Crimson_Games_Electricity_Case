using UnityEngine;

[CreateAssetMenu(menuName = "Chat/MessagePool")]
public class ChatMessagePool : ScriptableObject
{
    public string[] usernames = { "xX_ghost_Xx", "viewer123", "spookyfan" };

    [System.Serializable]
    public class Category
    {
        public string tag;
        public string[] messages;
    }

    public Category[] categories;

    public string GetRandom(string tag)
    {
        foreach (var cat in categories)
            if (cat.tag == tag)
                return cat.messages[Random.Range(0, cat.messages.Length)];

        return "lol";
    }

    public string GetRandomUsername()
    {
        return usernames[Random.Range(0, usernames.Length)];
    }
}