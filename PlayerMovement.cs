using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;

    private Vector2 moveDirection;

    public PlayerInput controls;
    private Vector2 move;

    private void Awake()
    {
        controls = new PlayerInput();

        controls.Player.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Player.Move.canceled += ctx => move = Vector2.zero;
    }


    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }
    void FixedUpdate()
    {
        Move();
    }
    void ProcessInputs()
    {
        //float moveX = Input.GetAxisRaw("Horizontal");
        //float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(move.x, move.y).normalized;
    }
    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

    private void OnEnable()
    {
        controls.Player.Enable();
    }

    private void OnDisable()
    {
        controls.Player.Disable();
    }
}
