using UnityEngine;
using TMPro;

public class EndingsUI : MonoBehaviour
{
    public TextMeshProUGUI EndingsUnlocked;

    void Update()
    {
        EndingsUnlocked.text = GameManager.Instance.EndingsUnlocked + " / 3";
    }
}
