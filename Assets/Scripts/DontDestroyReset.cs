using UnityEngine;
public class DontDestroyReset : MonoBehaviour
{
    public static DontDestroyReset Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}