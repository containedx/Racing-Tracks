using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool pause = false;

    public GameObject PauseScreen;

    void Update()
    {
        if( Input.GetKeyDown(KeyCode.P))
        {
            HandlePause();
        }
        if( Input.GetKey(KeyCode.Escape))
        {
            //Load Menu
        }
    }

    void HandlePause()
    {
        pause = !pause;

        if (pause)
        {
            PauseScreen.SetActive(true);
            Time.timeScale = 0; 
        }
        else
        {
            PauseScreen.SetActive(false);
            Time.timeScale = 1;  
        }
    }
}
