using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class hpBar : MonoBehaviour
{
    private playercollectibles player_interacted;
    public GameObject player; 
    public Image healthbar;
    public void Start()
    {
         player_interacted = player.GetComponent<playercollectibles>();
    }
    public void Update()
    {
        
        float interacted = player_interacted.interacted;
        Debug.Log(interacted * (1f/4f));
        healthbar.fillAmount = interacted * (1f / 4f);
    }
}
