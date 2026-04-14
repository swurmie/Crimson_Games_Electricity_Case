using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class playercollectibles : MonoBehaviour
{
    float haspick = 100;
    float hasblock = 0;
    private bool mine;
    private bool place;
    [SerializeField] GameObject obstacle;
    [SerializeField] GameObject spawner;
    

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Key")
        {
            haspick += 4;
            Debug.Log(haspick);
            Destroy(other.gameObject);
        }
    }

    private void Update()
    {
        mine = Keyboard.current.spaceKey.isPressed;
        place = Keyboard.current.vKey.wasPressedThisFrame;

        if (hasblock > 0 && place == true)
        {
            //Instantiate(obstacle, this.transform.position + this.transform.forward * 10, this.transform.rotation);
            Instantiate(obstacle, spawner.transform.position, spawner.transform.rotation);
            hasblock -= 1;
            Debug.Log(hasblock + " blocks");
        }
    }


    private void FixedUpdate()
    {
        
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle") && haspick > 0 && mine == true)
        {
            Destroy(collision.gameObject);
            haspick -= 1;
            Debug.Log(haspick + " picks");
            hasblock += 1;
            Debug.Log(hasblock + " blocks");
        }
    }
}
