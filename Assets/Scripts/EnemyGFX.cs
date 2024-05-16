using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyGFX : MonoBehaviour
{
    public AIPath aiPath;   //variable para el enemy pathfinding

    AudioSource audioSource;

    void Start ()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (aiPath.desiredVelocity.x >= 0.01f) //If movimiento a la derecha
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }

        else if (aiPath.desiredVelocity.x <= -0.01)// Else If movimiento a la izquierda
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }

        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
        else
        {
            audioSource.Stop();
        }
    }
}
