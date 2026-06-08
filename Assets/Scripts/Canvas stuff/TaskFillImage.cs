using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TaskFillImage : MonoBehaviour
{
    private playercollectibles player_interacted;
    public GameObject player; 
    public Image taskbar;
    void Start()
    {
         player_interacted = player.GetComponent<playercollectibles>();
    }
    void Update()
    {
        
        float interacted = player_interacted.interacted;
        //Debug.Log(interacted * (1f/6f));
        taskbar.fillAmount = interacted * (1f / 6f);
    }
}
