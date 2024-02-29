using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour : MonoBehaviour
{
    public float motiSpeed;
    private Vector2 motiDirection;
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixUpdate()
    {
        Move();
    }

    void ProcessInputs()
    {
        float speedX = Input.GetAxisRaw("Horizontal");
        float speedY = Input.GetAxisRaw("Vertical");
        motiDirection = new Vector2(speedX, speedY);
    }
    
    void Move()
    {
        rb.velocity = new Vector2(motiDirection.x * motiSpeed, motiDirection.y * motiSpeed);
    }

    void Update()
    {
        ProcessInputs();
    }
}
