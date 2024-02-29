using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour : MonoBehaviour
{
    public float motiSpeed;
    float speedX, speedY;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        speedX = Input.GetAxisRaw("Horizontal") * motiSpeed;
        speedY = Input.GetAxisRaw("Vertical") * motiSpeed;
        rb.velocity = new Vector2(speedX, speedY);
    }
}
