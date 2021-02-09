using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class TimeCounter : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    bool timerOn = false;

    void Start()
    {
        timerText.text = "0,0";
        StartCoroutine(StartTimer());
    }

    void Update()
    {
        if(timerOn)
        {
            timerText.text = (Time.timeSinceLevelLoadAsDouble - 4f).ToString("F2");
        }
    }

    IEnumerator StartTimer()
    {
        yield return new WaitForSeconds(4f);
        timerOn = true;
    }
}
