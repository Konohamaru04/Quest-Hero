using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseUI;
    private bool Paused = false;

    void Start()
    {
        PauseUI.SetActive(false);   
    }

    void Update()
    {
        if(Input.GetButtonDown("Pause"))
        {
            Paused = !Paused;
        }

        if(Paused)
        {
            PauseUI.SetActive(true);
            Time.timeScale = 0;
        }

        if(!Paused)
        {
            PauseUI.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void Resume()
    {
        Paused = false;
    }
    
    public void Restart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void MainMenu()
    {
        Application.LoadLevel(0);
    }

    public void Quit()
    {
        Application.Quit();
    }
}


