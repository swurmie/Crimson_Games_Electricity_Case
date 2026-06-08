using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public bool endingPerfect;
    public bool endingGood;
    public bool endingBad;

    public int EndingsUnlocked => 
        (endingPerfect ? 1 : 0) + (endingGood ? 1 : 0) + (endingBad ? 1 : 0);

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