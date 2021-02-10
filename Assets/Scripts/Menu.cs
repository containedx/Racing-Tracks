using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject about;
    public GameObject controls;
    public GameObject credits;

    public void Track1()
    {
        SceneManager.LoadScene("Level1");
    }


    public void Exit()
    {
        Application.Quit();
    }

    public void About()
    {
        about.SetActive(true);
    }
    public void DesactivateAbout()
    {
        about.SetActive(false);
    }

    public void Controls()
    {
        controls.SetActive(true);
    }
    public void DesactivateControls()
    {
        controls.SetActive(false);
    }

    public void Credits()
    {
        credits.SetActive(true);
    }
    public void DesactivateCredits()
    {
        credits.SetActive(false);
    }
}
