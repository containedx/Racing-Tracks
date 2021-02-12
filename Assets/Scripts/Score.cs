using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI text;

    public void SetValue(float score, float bestscore)
    {
        text.text = "your time: " + score.ToString() + "\nbest time: " + bestscore.ToString() +
                    "\n\npress ESC to go back to menu\npress SPACE to drive lap one more time";
    }
}
