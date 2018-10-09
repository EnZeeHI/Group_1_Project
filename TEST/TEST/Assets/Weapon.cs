﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public Transform firePoint;
    public GameObject bulletPrefab;
    public int gunHolder = 1;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1") && gunHolder == 1)
        {
            Shoot();
        }

        if (Input.GetButtonDown("swapGun1"))
        {
            gunHolder = 2;
        }

        if (Input.GetButtonDown("swapGun2"))
        {
            gunHolder = 1;
        }
    }

    void Shoot ()
    {
        Debug.Log("Hi");
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

}