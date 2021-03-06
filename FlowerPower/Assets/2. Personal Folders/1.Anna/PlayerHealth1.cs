﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth1 : MonoBehaviour
{
    public PlayerStats playerStats;
    public TextMeshProUGUI textBoxObjective;
    public TextMeshProUGUI textBoxTime;
    private bool startTimer;
    public float timeTillDeath;
    [HideInInspector] public bool theyDidIt;

    private void Update()
    {
        /*  timeTillDeath -= Time.deltaTime;
          if (startTimer)
          {
              textBoxObjective.text = "Find Water";
              textBoxTime.text = "Time Remaining: " + (int)timeTillDeath;
          }

          if (!theyDidIt)
          {
              if (timeTillDeath <= 0)
              {
                  playerStats.TakeDamage();
              }
          }
          else textBoxTime.text = "";*/
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && playerStats.currentHealth >= 1)
        {
            startTimer = true;
            for (int i = 0; i < 5; i++)
            {
                playerStats.TakeDamage();
            }
        }


    }
}

