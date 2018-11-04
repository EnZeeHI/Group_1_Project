using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public GameObject enemy;
    public float timeStamp;
    public Transform spawnspot;
    public float cooldown = 25;

    // Use this for initialization
    void Start()
    {
        timeStamp = Time.time + 5;
    }

    // Update is called once per frame
    void Update()
    {

        if (timeStamp <= Time.time)
        {
            timeStamp = Time.time + cooldown;
            Spawn();


        }
    }

    void Spawn()
    {
        Instantiate(enemy, spawnspot.position, spawnspot.rotation);
    }
}
