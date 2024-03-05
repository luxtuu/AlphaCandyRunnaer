using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour : MonoBehaviour
{
    public float motiSpeed;
    private float movementX, movementY;
    private Rigidbody2D rbCharacter;
    private Vector2 cursoDeMovement;
    [SerializeField] Animator animi;

    void Start()
    {
        rbCharacter = this.GetComponent<Rigidbody2D>();
        //animator = GetComponent<Animator>();
    }

    void Update()
    {
        EncierroDePulso();
        animi.SetFloat("Horizontal", cursoDeMovement.x);
        animi.SetFloat("Vertical", cursoDeMovement.y);
        // speedX = Input.GetAxisRaw("Horizontal") * motiSpeed;
        // animator.SetFloat("Horizontal", Mathf.Abs(speedX));

        //  speedY = Input.GetAxisRaw("Vertical") * motiSpeed;
        //animator.SetFloat("Vertical", Mathf.Abs(speedY));
        //  rb.velocity = new Vector2(speedX, speedY);
    }

    private void FixedUpdate()
    {
        MoveOfCharacter();
    }

    void EncierroDePulso()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        movementY = Input.GetAxisRaw("Vertical");
        cursoDeMovement = new Vector2(movementX, movementY);
    }

    void MoveOfCharacter()
    {
        rbCharacter.velocity = new Vector2(cursoDeMovement.x * motiSpeed, cursoDeMovement.y * motiSpeed);
    }
}
