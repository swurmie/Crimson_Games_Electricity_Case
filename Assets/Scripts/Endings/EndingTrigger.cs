using UnityEngine;

public class EndingTrigger : MonoBehaviour
{
    public enum EndingType { Perfect, Good, Bad }
    public EndingType ending;

    void OnEnable()
    {
        switch (ending)
        {
            case EndingType.Perfect: GameManager.Instance.endingPerfect = true; break;
            case EndingType.Good:    GameManager.Instance.endingGood = true;    break;
            case EndingType.Bad:     GameManager.Instance.endingBad = true;     break;
        }
    }
}