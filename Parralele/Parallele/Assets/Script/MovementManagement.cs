using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManagement : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    public Transform feetPos;
    public float checkRaduis;
    public LayerMask whatIsGround;

    private float moveInput;
    private bool isGrounded;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRaduis, whatIsGround);
        if (isGrounded == true && Input.GetKey(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
        rb.drag = 0f;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(feetPos.position, checkRaduis);
    }
}
