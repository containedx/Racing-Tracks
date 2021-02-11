using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI text;

    public void SetValue(float score, float bestscore)
    {
        text.text = "your time: " + score.ToString() + "\n\nbest time: " + bestscore.ToString();
    }
}
