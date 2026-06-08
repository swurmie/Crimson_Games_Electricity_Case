using UnityEngine;

public class EndDay : MonoBehaviour
{
    private playercollectibles player_interacted;
    public GameObject player;
    private ScoreManager score_manager;
    public GameObject scoreManagerObject;
    private float score; //
    private float interacted;
    public GameObject NotDone;
    public GameObject YouDone;
    //Endings
    public GameObject Perfect;
    public GameObject Good;
    public GameObject Bad;

    void Start()
    {
        player_interacted = player.GetComponent<playercollectibles>();
        score_manager = scoreManagerObject.GetComponent<ScoreManager>();
    }

    void Update()
    {
        interacted = player_interacted.interacted;
        score = score_manager.score; //
        if (gameObject.CompareTag("DoorClicked"))
        {
            if (interacted == 4f)
            {
                Calculate();
                Debug.Log("Calculating");
            }
            else
            {
                NotDone.SetActive(true);
                gameObject.tag = "Door";
                Debug.Log("ResetTag");
            }
        }
    }

    void Calculate()
    {
        if (score == 400)
        {
            Debug.Log("Perfect");
            Perfect.SetActive(true);
        }
        else if (score >= 202)
        {
            Debug.Log("Good");
            Good.SetActive(true);
        }
        else if (score >= 0)
        {
            Debug.Log("Bad");
            Bad.SetActive(true);
        }

        gameObject.tag = "Untagged";
        YouDone.SetActive(false);
    }
}