using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

    public float speed;
    public float stoppingDistance;
    public Transform target;
    public string player;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        

        MovementP2 player = hitInfo.GetComponent<MovementP2>();
        if (player != null)
        {   
            Destroy(player.gameObject);
        }


        
    }

}
