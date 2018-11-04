using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPlayer1 : MonoBehaviour {

    public Transform firePoint;
    public GameObject bulletPrefab;
    public int gunHolder = 2;

    public float timeStamp;
    public float cooldown;
    public AudioClip ShootClip;
    public AudioSource ShootSource;

    void Start()
    {
        timeStamp = Time.time;
        ShootSource.clip = ShootClip;

    }

    // Update is called once per frame
    void Update()
    {
        if (timeStamp <= Time.time)
        {
            if (Input.GetButtonDown("Fire1") && gunHolder == 1)
            {
                timeStamp = Time.time + cooldown;
                Shoot();
                ShootSource.Play();
            }
        }

        if (Input.GetButtonDown("swapGun2"))
        {
            gunHolder = 2;
        }

        if (Input.GetButtonDown("swapGun1"))
        {
            gunHolder = 1;
        }
    }

    void Shoot()
    {
        
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
