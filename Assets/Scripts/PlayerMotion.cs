using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotion : MonoBehaviour
{

    public float motionSpeed = 5f;

    public Rigidbody2D rbPlayer;
    public Animator animi;

    Vector2 motion;

    // Update is called once per frame
    void Update()
    {
        motion.x = Input.GetAxisRaw("Horizontal");
        motion.y = Input.GetAxisRaw("Vertical");

        animi.SetFloat("Horizontal", motion.x);
        animi.SetFloat("Vertical", motion.y);
        animi.SetFloat("Speed", motion.sqrMagnitude);
    }

    void FixedUpdate()
    {
        rbPlayer.MovePosition(rbPlayer.position + motion * motionSpeed * Time.fixedDeltaTime);
    }

}
