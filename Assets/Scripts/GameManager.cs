using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool pause = false;

    public GameObject PauseScreen;
    public GameObject FinishScreen;
    public GameObject GameOverScreen;

    public Car car;

    void Start()
    {
        Time.timeScale = 1; 
    }

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
        if( Input.GetKey(KeyCode.Space))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
        if(car.finish == true)
        {
            FinishScreen.SetActive(true);
            Time.timeScale = 0;
        }
        if(car.live == false)
        {
            GameOverScreen.SetActive(true);
            Time.timeScale = 0;
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
