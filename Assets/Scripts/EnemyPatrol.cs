using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour 
{
    public float speed; //variable para velocidad
    private float waitTime; // variable tiempo de espera para movimiento
    public float startWaitTime;

    public Transform moveSpot; // variable de movimiento

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    void Start()
    {
        waitTime = startWaitTime;

        moveSpot.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
    }

    void Update()
    {
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
        }
    }

}
