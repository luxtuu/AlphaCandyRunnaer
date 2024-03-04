using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour : MonoBehaviour
{
    public float motiSpeed;
    float speedX = 0f;
    float speedY = 0f;
    Rigidbody2D rb;
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        speedX = Input.GetAxisRaw("Horizontal") * motiSpeed;
        animator.SetFloat("Horizontal", Mathf.Abs(speedX));

        speedY = Input.GetAxisRaw("Vertical") * motiSpeed;
        //animator.SetFloat("Vertical", Mathf.Abs(speedY));
        rb.velocity = new Vector2(speedX, speedY);
    }
}
