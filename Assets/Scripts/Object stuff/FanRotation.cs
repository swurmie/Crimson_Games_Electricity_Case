using UnityEngine;

public class FanRotation : MonoBehaviour
{
    [SerializeField] private float speed = 1;
    void Update()
    {
        transform.Rotate(0 ,speed * Time.deltaTime , 0);
    }
}
