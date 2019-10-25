using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float runS = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    public int curHealth = 0;
    public int maxHealth = 1;
    void Start()
    {
        curHealth = maxHealth;
    }
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runS;   

        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if(curHealth > maxHealth)
        {
            curHealth = maxHealth;
        }

        if(curHealth <= 0)
        {
            die();
        }
    }
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
    void die()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void Damage()
    {
        curHealth = 0;
    }
}
