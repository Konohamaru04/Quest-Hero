using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instructionController : MonoBehaviour
{
    public GameObject instUi;

    void Start()
    {   
    }

    void Update()
    {
    }
    
    public void Play()
    {
        Application.LoadLevel(1);
    }
}
