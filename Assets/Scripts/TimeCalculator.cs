using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeCalculator : MonoBehaviour
{

    private float tickSpeedHolder;
    [SerializeField] private float tickSpeed;
    [SerializeField] private int hours;
    [SerializeField] private int minutes;

    [SerializeField] private TextMeshProUGUI timerText;

    [SerializeField] public static bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        tickSpeedHolder = tickSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        tickSpeed -= Time.deltaTime;

        if (tickSpeed <= 0)
        {
            if (hours < 10 && minutes < 10) timerText.text = "0" + hours + ":0" + minutes;
            else if (minutes < 10) timerText.text = hours + ":0" + minutes;
            else timerText.text = hours + ":" + minutes;
            //do something with deltatime and time display
            minutes++;
            if (minutes == 60)
            {
                minutes = 0;
                hours++;
            }
            tickSpeed = tickSpeedHolder;
        }

    }
}
