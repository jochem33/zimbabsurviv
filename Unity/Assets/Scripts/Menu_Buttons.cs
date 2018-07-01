using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class Menu_Buttons : MonoBehaviour {

    public GameObject Play;
    public GameObject About;
    public GameObject Main;
    public GameObject Options;

    public void MenuPlayLoadgame()
    {
        SceneManager.LoadScene("Game");
    }

    public void MenuAbout()
    {
        Main.SetActive(false);
        About.SetActive(true);
    }

    public void MenuPlay()
    {
        Main.SetActive(false);
        Play.SetActive(true);
    }

    public void MenuOptions()
    {
        Main.SetActive(false);
        Options.SetActive(true);
    }

    public void MenuQuit()
    {
        Application.Quit();
    }

    public void MenuOptionsBack()
    {
        Main.SetActive(true);
        Options.SetActive(false);
    }

    public void MenuAboutBack()
    {
        Main.SetActive(true);
        About.SetActive(false);
    }

    public void MenuPlayBack()
    {
        Main.SetActive(true);
        Play.SetActive(false);
    }

}
