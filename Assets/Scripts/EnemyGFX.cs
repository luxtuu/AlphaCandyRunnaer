using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyGFX : MonoBehaviour
{
    public GameObject player;

    public float speed;

    AudioSource audioSource;

    void Start ()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = player.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);

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
