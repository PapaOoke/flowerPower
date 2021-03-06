﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformButton : MonoBehaviour
{
    public Animator anim;
    public bool buttonPressed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (buttonPressed)
        {
            anim.enabled = false;
        }
        
    }

    private void OnTriggerStay(Collider other)
    {
        if ((other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E) || other.CompareTag("Bullet")))
        {
            buttonPressed = true;
            anim.enabled = false;
        }
    }
}
