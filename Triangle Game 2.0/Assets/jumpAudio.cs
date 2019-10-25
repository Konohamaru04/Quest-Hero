using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpAudio : MonoBehaviour
{
    
    public AudioSource jmpAudio;
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            jmpAudio.Play();
        }
         
    }
}
