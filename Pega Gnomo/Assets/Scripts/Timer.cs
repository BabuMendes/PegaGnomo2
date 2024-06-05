using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private GerenciadorDoJogo gerenciadorDoJogo;

    [SerializeField] private TMP_Text timerTxt;

    private float min;
    private float sec;
    private bool isGameOver;

    void Start()
    {
        isGameOver = false;
        SetTimer(0, 45);
    }

    void Update()
    {
        if (!isGameOver && gerenciadorDoJogo.jogoON)
        {
            CountTime();
        }
    }

    public void SetTimer(float min, float sec)
    {
        this.min = min;
        this.sec = sec;
    }

    private void CountTime()
    {
        if (min >= 0)
        {
            sec -= 1 * Time.deltaTime;

            if (sec <= 0)
            {
                min -= 1;
                sec = 59;
            }
        }

        if (min < 0)
        {
            min = 0;
            sec = 0;
            isGameOver = true;
            gerenciadorDoJogo.MortePorTempo();
            GameOver();
            //Time.timeScale = 0f;
        }

        if (sec >= 9.5f)
        {
            timerTxt.SetText("0" + min + ":" + Mathf.Round(sec));
        }
        else
        {
            timerTxt.SetText("0" + min + ":0" + Mathf.Round(sec));
        }
    }

    private void GameOver()
    {
        gerenciadorDoJogo.Morreu();
    }
}
