using UnityEngine;

public class FlickerRec : MonoBehaviour
{
    public GameObject myCanvas;
    public int timer = 0;

    private void Start()
    {
        
    }
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (timer > 0 && timer < 200)
        {
            timer += 1;
        }
        else
        {
            timer = 1;
        }
        if (timer > 0 && timer < 100)
        {
            myCanvas.SetActive(true);
        }
        else
        {
            myCanvas.SetActive(false);
        }

    }
}
