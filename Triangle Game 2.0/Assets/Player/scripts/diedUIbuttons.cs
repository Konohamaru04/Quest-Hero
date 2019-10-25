using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diedUIbuttons : MonoBehaviour
{
    public GameObject diedUI;
    public void Restart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void MainMenu()
    {
        Application.LoadLevel(0);
    }
}
