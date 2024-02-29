using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private TMP_Text _timerText;

    private bool _isRunning;

    public bool isGameOver;
    private float _timeToDisplay = 0.0f;

    private void Awake()
    {
        _timerText = GetComponent<TMP_Text>();
    }

    private void OnEnable()
    {
        EventManager.TimerStart += EventManagerOnTimerStart;
        EventManager.TimerStop += EventManagerOnTimerStop;
    }

    private void OnDisable()
    {
        EventManager.TimerStart -= EventManagerOnTimerStart;
        EventManager.TimerStop -= EventManagerOnTimerStop;
    }

    private void EventManagerOnTimerStart()
    {
        _isRunning = true;
    }

    private void EventManagerOnTimerStop()
    {
        _isRunning = false;
    }

    private void Update()
    {
        if (!_isRunning)
        {
            return;
        }
        if (isGameOver)
        {
            EventManagerOnTimerStop();
            CancelInvoke("SpawnRandomAnimal");
        
            return;
        }

        _timeToDisplay += Time.deltaTime;

        TimeSpan timespan = TimeSpan.FromSeconds(_timeToDisplay);
        _timerText.text = timespan.ToString(@"mm\:ss\:ff");
    }
}
