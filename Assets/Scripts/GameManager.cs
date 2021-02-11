using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool pause = false;

    public GameObject PauseScreen;
    public GameObject FinishScreen;

    public Car car;

    void Update()
    {
        if( Input.GetKeyDown(KeyCode.P))
        {
            HandlePause();
        }
        if( Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
        
        if(car.finish == true)
        {
            FinishScreen.SetActive(true);
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
