using UnityEngine;

public class ExitManager : MonoBehaviour
{
    public static Exitmanager Instance;
    public int score = 0;

    void Awake()
    {
        Instance = this;
    }

    public void AddScore(int amount)
    {
        
    }
}
