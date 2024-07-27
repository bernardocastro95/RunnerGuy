using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public Text chronometer, score, scoreRecord, timeRecord;
    private float currentTime;
    private int currentScore;
    private bool timerActive;
    private float distanceRunned;
    [SerializeField]
    public Character character;
    public Text gameover;
    public Button restart;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0f;
        currentScore = 0;
        startTime();
        restart.onClick.AddListener(restartGame);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        chronometerTimer();
        scoreManager();
        if(character.hit == true)
        {
            stopTimer();
        }
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
    public void highScoreSetter()
    {
        if (PlayerPrefs.HasKey("highscore"))
        {
            if (currentScore > PlayerPrefs.GetInt("highscore"))
            {
                PlayerPrefs.SetInt("highscore", currentScore);           
            }
        }
        else
        {
            PlayerPrefs.SetInt("highscore", currentScore);
        }
        scoreRecord.text = PlayerPrefs.GetInt("highscore").ToString();
    }

    public void timeScoreSetter()
    {
        if (PlayerPrefs.HasKey("timeScore"))
        {
            if(currentTime > PlayerPrefs.GetFloat("timeScore"))
            {
                PlayerPrefs.SetFloat("timeScore", currentTime);
                

            }
        }
        else
        {
            PlayerPrefs.SetFloat("timeScore", currentTime);
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        timeRecord.text = PlayerPrefs.GetFloat("timeScore").ToString();
        timeRecord.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();
    }

    public void gameOverText()
    {
        gameover.text = "GAME OVER";
    }

    public void revealBUtton()
    {
        restart.gameObject.SetActive(true);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(0);
        gameover.text = "";
        restart.gameObject.SetActive(false);
        timeRecord.text = PlayerPrefs.GetFloat("timeScore").ToString();
        scoreRecord.text = PlayerPrefs.GetInt("highscore").ToString();


    }
}
