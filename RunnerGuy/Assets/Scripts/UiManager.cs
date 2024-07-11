using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public Text chronometer, score;
    private float currentTime;
    private int currentScore;
    private bool timerActive;
    private float distanceRunned;
    [SerializeField]
    private Character character;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0f;
        startTime();
        distanceRunned = distanceRunned * 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        chronometerTimer();
        scoreManager();
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
    void scoreManager()
    {
        distanceRunned = character.transform.position.x * -1;
        currentScore = (int)distanceRunned * 10;
        score.text = currentScore.ToString();
        
    }
}
