﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunflowerSeedProjectile : MonoBehaviour
{
    public float projectileSpawnOffset;
    public GameObject sunFlowerSeedPrefab;
    public GameObject projectileSpawnLocation;
    GameObject spawnedProjectile;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            spawnedProjectile = Instantiate(sunFlowerSeedPrefab, projectileSpawnLocation.transform.position, transform.rotation);
        }
    }
}
