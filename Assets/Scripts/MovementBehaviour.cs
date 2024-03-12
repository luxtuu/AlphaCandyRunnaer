using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour : MonoBehaviour
{
    //public float characterMotion;
    private Vector2 characterMotion;

   //public float motiSpeed;
   //private float movementX, movementY;
    public Rigidbody2D rbCharacter;
    public SpriteRenderer sprite;
    public float motiSpeed;
   //private Vector2 cursoDeMovement;
    public Animator animi;

    void Start()
    {
        rbCharacter = this.GetComponent<Rigidbody2D>();
        //animator = GetComponent<Animator>();
    }

    void Update()
    {
        HandleMotion();
        Animation();
       // EncierroDePulso();
        //animi.SetFloat("Horizontal", cursoDeMovement.x);
        //animi.SetFloat("Vertical", cursoDeMovement.y);
        // speedX = Input.GetAxisRaw("Horizontal") * motiSpeed;
        // animator.SetFloat("Horizontal", Mathf.Abs(speedX));

        //  speedY = Input.GetAxisRaw("Vertical") * motiSpeed;
        //animator.SetFloat("Vertical", Mathf.Abs(speedY));
        //  rb.velocity = new Vector2(speedX, speedY);
    }

    void Animation()
    {
        animi.SetFloat("Horizontal", characterMotion.x);
        animi.SetFloat("Speed", characterMotion.sqrMagnitude);
        animi.SetFloat("Vertical", characterMotion.y);
        animi.SetFloat("Speed", characterMotion.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        rbCharacter.velocity = new Vector2(characterMotion.x * motiSpeed, rbCharacter.velocity.y);
        rbCharacter.velocity = new Vector2(characterMotion.y * motiSpeed, rbCharacter.velocity.x);
        //MoveOfCharacter();
    }

    void HandleMotion()
    {
        characterMotion.x = Input.GetAxis("Horizontal");
        characterMotion.y = Input.GetAxis("Vertical");
    }

   /* void EncierroDePulso()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        movementY = Input.GetAxisRaw("Vertical");
        cursoDeMovement = new Vector2(movementX, movementY);
    }

    void MoveOfCharacter()
    {
        rbCharacter.velocity = new Vector2(cursoDeMovement.x * motiSpeed, cursoDeMovement.y * motiSpeed);
    }*/
}
