using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CandyScoreboard : MonoBehaviour
{

    private int candyTotal;
    public Text candiesText;
    void Start()
    {
        candyTotal = 0;
    }

    private void Update()
    {

        if(candyTotal == 10)
        {
            candiesText.text = "Ganastes!!";
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Dulces")
        {
            candyTotal++;
            candiesText.text = "Candies = " + candyTotal;
        }
    }
}
