using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DataStorage : MonoBehaviour
{
    public GameManager gameManager;
    public TimeCounter time;

    public Score Scores;

    [SerializeField]
    float score;
    [SerializeField]
    float bestscore=1000f;

    [SerializeField]
    int level;
    string BESTSCORE;

    void Start()
    {
        BESTSCORE = "BestScore" + level.ToString();
        Load();
    }

    void Update()
    {
        if(gameManager.car.finish)
        {
            score = (float)time.resultTime;
            Save();
            Scores.SetValue(score, bestscore);
        }
    }


    void Load()
    {
        bestscore = PlayerPrefs.GetFloat(BESTSCORE);
    }

    void Save()
    {
        SetBest();
        PlayerPrefs.SetFloat(BESTSCORE, bestscore);
    }

    void SetBest()
    {
        if(score < bestscore)
        {
            bestscore = score;
        }
    }
}

