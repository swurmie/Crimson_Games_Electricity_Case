using UnityEngine;
using UnityEngine.UI;

public class EndingsFillImage : MonoBehaviour
{
    public Image endingsfill;

    void Update()
    {
        endingsfill.fillAmount = GameManager.Instance.EndingsUnlocked / 3f;
    }
}