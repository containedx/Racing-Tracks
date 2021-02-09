using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    public GameObject Screen;

    public TextMeshProUGUI countText;
    int secondsToStart = 3;
    
    void Start()
    {
        StartCoroutine(Count());
    }

    IEnumerator Count()
    {
        while (secondsToStart > 0)
        {
            countText.text = secondsToStart.ToString();
            secondsToStart--;
            yield return new WaitForSeconds(1f);
        }

        countText.text = "GO!";
        yield return new WaitForSeconds(1f);

        Screen.SetActive(false);
    }
}
