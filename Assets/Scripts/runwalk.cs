using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class runwalk : MonoBehaviour
{
    bool _moveForward = false;
    Animator ani;
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    void Update()
    {
        
        _moveForward = Keyboard.current.wKey.isPressed;
        if (_moveForward)
        {
            ani.SetBool("run", true);
        }
        else
        {
            ani.SetBool("run", false);
        }
    }
}

