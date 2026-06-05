using UnityEngine;

public class EInteractCheck : MonoBehaviour
{
    public float detectionRadius = 2.3f;
    private Transform player;
    private bool playerNearby = false;
    public GameObject InteractOverlay;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance <= detectionRadius && !playerNearby && (gameObject.CompareTag("Interactable") || gameObject.CompareTag("Door")))
        {
            playerNearby = true;
            OnPlayerEnter();
        }
        else if (distance <= detectionRadius && playerNearby )
        {
            if (!gameObject.CompareTag("Interactable") && !gameObject.CompareTag("Door"))
            {
                playerNearby = false;
                OnPlayerExit();
            }
        }
        else if (distance > detectionRadius && playerNearby)
        {
            playerNearby = false;
            OnPlayerExit();
        }
    }

    void OnPlayerEnter()
    {
        InteractOverlay.SetActive(true);
        //Debug.Log("Entered Zone");
    }

    void OnPlayerExit()
    {
        InteractOverlay.SetActive(false);
        //Debug.Log("Left Zone");
    }
}