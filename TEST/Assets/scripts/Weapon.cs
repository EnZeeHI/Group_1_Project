using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public Transform firePoint;
    public GameObject bulletPrefab;
    public int gunHolder = 1;


    public float timeStamp;


    void Start()
    {
        timeStamp = Time.time;

    }


    // Update is called once per frame
    void FixedUpdate () {

        if (timeStamp <= Time.time) {
            if (Input.GetButtonDown("Fire1") && gunHolder == 1)
            {
                timeStamp = Time.time + 1;
                Shoot();
            }
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
        
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

}
