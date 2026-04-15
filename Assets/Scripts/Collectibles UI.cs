using UnityEngine;
using TMPro;

public class CollectiblesUI : MonoBehaviour
{
    private playercollectibles player_interacted;
    public TextMeshProUGUI amountImproved;
    public GameObject player;
    void Start()
    {
        player_interacted = player.GetComponent<playercollectibles>();
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        string interacted = player_interacted.interacted.ToString();
        amountImproved.text = interacted;
    }
}
