using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;

    void Start()
    {   
    }

    void Update()
    {
    }
    
    public void Play()
    {
        Application.LoadLevel(4);
    }


    public void Quit()
    {
        Application.Quit();
    }
}
