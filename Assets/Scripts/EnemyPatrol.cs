using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour 
{
    public GameObject player; 

    public float speed; //variable para velocidad
    private float waitTime; // variable tiempo de espera para movimiento
    public float startWaitTime;
    public float distanceBetween;

    public Transform moveSpot; // variable de movimiento

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    AudioSource audioSource;

    private float distance;

    void Start()
    {
        waitTime = startWaitTime;

        moveSpot.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));

        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);

        transform.position = Vector2.MoveTowards(transform.position, moveSpot.position, speed * Time.deltaTime); //movimeinto del enemigo

        if (Vector2.Distance(transform.position, moveSpot.position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                moveSpot.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));

                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;

            }
            if (!audioSource. isPlaying)
            {
                audioSource.Play();
            }
            else
            {
                audioSource.Stop();
            }
        }
        if(distance < distanceBetween)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);         
        }

    }

}
