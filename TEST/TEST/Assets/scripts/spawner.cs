using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public GameObject enemy;
    public float timeStamp;
    public Transform spawnspot;

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
            timeStamp = Time.time + 15;
            Spawn();


        }
    }

    void Spawn()
    {
        Instantiate(enemy, spawnspot.position, spawnspot.rotation);
    }
}
