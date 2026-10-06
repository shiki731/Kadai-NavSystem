using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    Rigidbody rb;
    InputAction _move;
    
    public float speed = 5.0f;
    
    private float axisX = 0.0f;
    private float axisZ = 0.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        PlayerInput input = rb.GetComponent<PlayerInput>();
        _move = input.currentActionMap.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {


        // ˆÚ“®
        axisX = _move.ReadValue<Vector2>().x;
        axisZ = _move.ReadValue<Vector2>().y;

        //Debug.Log(axisX);
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(axisX * speed, 0, axisZ * speed);
    }
}
