using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private Rigidbody _rb;

    void Start()
    {
        UnityEngine.Debug.Log("<color=#ff85fb> Start </color>");
        _rb = GetComponent<Rigidbody>();
    }

    [SerializeField] private float maxspeed = 1f;
    [SerializeField] private float minspeed = -0.2f;
    [SerializeField] private float rotatespeed = 1f;
    private float rbvel;
    public float forwardspeed = 0;
    private float lastForwardSpeed = 0;

    private bool _moveForward;
    private bool _moveBackward;
    private bool _rotateLeft;
    private bool _rotateRight;
    private bool _sprint;
    private bool _initiateJump;

    void Update()
    { // if (Keyboard.current.rKey.wasPressedThisFrame == true)
        //button inputs
        _moveForward = Keyboard.current.wKey.isPressed;
        _moveBackward = Keyboard.current.sKey.isPressed;
        _rotateLeft = Keyboard.current.aKey.isPressed;
        _rotateRight = Keyboard.current.dKey.isPressed;
        _sprint = Keyboard.current.shiftKey.isPressed;
        _initiateJump = Keyboard.current.spaceKey.isPressed;
        //

        if (_moveForward && !_moveBackward)
        {
            forwardspeed += Time.deltaTime;
            forwardspeed = Mathf.Min(forwardspeed, maxspeed); // will take the lowest of the 2 accel values (current accel or max accel) so it doesnt exceed 1 
        }
        else if (_moveBackward && !_moveForward)
        {
            forwardspeed -= Time.deltaTime;
            forwardspeed = Mathf.Max(forwardspeed, minspeed); // same as forward accel
        }
        else
        {
            if (forwardspeed > 0)
            {
                forwardspeed -= Time.deltaTime * 2;
                if (forwardspeed < 0) forwardspeed = 0; // 
            }
            else if (forwardspeed < 0)
            {
                forwardspeed += Time.deltaTime * 2;
                if (forwardspeed > 0) forwardspeed = 0; // Don't overshoot
            }
        }
        if (forwardspeed != lastForwardSpeed) //logging used for testing accel
        {
            //Debug.Log(forwardspeed);
            lastForwardSpeed = forwardspeed;
        }
        
    }

    void FixedUpdate()
    {
        if (forwardspeed != 0)
        {
            if (_sprint)
            {
                _rb.linearVelocity = transform.forward * (forwardspeed * 170) + Vector3.up * _rb.linearVelocity.y;
            }
            else
            {
                _rb.linearVelocity = transform.forward * (forwardspeed * 100) + Vector3.up * _rb.linearVelocity.y;
            }
        }
        //rotating
        if (_rotateLeft)
        {
            _rb.MoveRotation(_rb.rotation * Quaternion.Euler(0, -250 * rotatespeed * Time.deltaTime, 0));
            //UnityEngine.Debug.Log("rotate left");
        }
        if (_rotateRight)
        {
            _rb.MoveRotation(_rb.rotation * Quaternion.Euler(0, 250 * rotatespeed * Time.deltaTime, 0));
            //UnityEngine.Debug.Log("rotate right");
        }

            
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            forwardspeed = 0;
        }
    }
}