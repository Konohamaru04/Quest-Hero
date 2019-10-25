using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D Col)
    {
        if(Col.CompareTag("Player"))
        {
            Application.LoadLevel(2);
        }
    }
}
