using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI text;

    public void SetValue(double value)
    {
        text.text = "your time: " + value;
    }
}
