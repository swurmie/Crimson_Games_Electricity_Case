using UnityEngine;

public class CanStopStreaming : MonoBehaviour
{
    private playercollectibles player_interacted;
    public GameObject player;
    public GameObject YouDone;
    private float interacted;
void Start()
    {
        player_interacted = player.GetComponent<playercollectibles>();
    }

    void Update()
    {
        interacted = player_interacted.interacted;
        if (interacted == 4f)
        {
            Debug.Log("YouDone");
            YouDone.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
