using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public Text chronometer, score;
    private float currentTime;
    private bool timerActive;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0f;
        startTime();
    }

    // Update is called once per frame
    void Update()
    {
        chronometerTimer();
    }
    void chronometerTimer()
    {
        if (timerActive)
        {
            currentTime += Time.deltaTime;
            TimeSpan time = TimeSpan.FromSeconds(currentTime);
            chronometer.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();

        }
    }

    void startTime()
    {
        timerActive = true;
    }
    void stopTimer()
    {
        timerActive = false;
    }
}
