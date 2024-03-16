using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountDownTimer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI countdownTimeText;
    [SerializeField] float remainingTime;

    
    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;
            countdownTimeText.color = Color.red;
        }
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        countdownTimeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        //countdownTimeText.text = elapsedTime.ToString();
    }
}
