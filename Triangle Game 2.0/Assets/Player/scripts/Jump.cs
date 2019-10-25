using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
   public AudioSource jump;

   void Update()
   {
       if(Input.GetButtonDown("Jump"))
        {
            jump.Play();
        }
   }
}
