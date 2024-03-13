using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthHeart : MonoBehaviour
{
    public int vida;
    public int numDeVidas;

    public Image[] vidas;
    public Sprite vidaCompleta;
    public Sprite vidaVacia;

    void Update()
    {
        for(int i = 0; i < vidas.Length; i++)
        {
            if(vida > numDeVidas)
            {
                vida = numDeVidas;
            }

            if (i < numDeVidas)
            {
                vidas[i].sprite = vidaCompleta;
            }
            else
            {
                vidas[i].sprite = vidaVacia;
            }

            if(i < numDeVidas)
            {
                vidas[i].enabled = true;
            }
            else
            {
                vidas[i].enabled = false;
            }
        }
    }
}
