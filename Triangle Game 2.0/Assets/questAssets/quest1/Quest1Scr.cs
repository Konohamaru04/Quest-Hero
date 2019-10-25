using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Quest1Scr : MonoBehaviour
{
    public GameObject questionUI;
    void Start()
    {   
    }

    void Update()
    {
    }
    
    public void AnsA()
    {
        Application.LoadLevel(3);
    }

    public void AnsB()
    {
        Application.LoadLevel(1);
    }
}
