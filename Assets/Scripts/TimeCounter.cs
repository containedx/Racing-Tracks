using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class TimeCounter : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    bool timerOn = false;
    double delay = 0.0f;

    double resultTime;

    void Start()
    {
        timerText.text = "0,0";
    }

    void Update()
    {
        if(timerOn)
        {
            timerText.text = (Time.timeSinceLevelLoadAsDouble - delay).ToString("F2");
        }
    }

    public void StartTimer()
    {
        delay = Time.timeSinceLevelLoadAsDouble;
        timerOn = true;
    }

    public double MeasureTime()
    {
        timerOn = false;
        resultTime = System.Math.Round(Time.timeSinceLevelLoadAsDouble - delay, 2);
        return resultTime;
    }
}
