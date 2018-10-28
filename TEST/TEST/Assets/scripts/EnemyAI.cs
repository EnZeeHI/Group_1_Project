using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyAI : MonoBehaviour {

    public float speed;
    public float stoppingDistance;
    public Transform target;
    public string player;
    Scene scene;

    public float timeStamp;
    public float cooldown = 5;



    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player2").GetComponent<Transform>();

        Scene scene = SceneManager.GetActiveScene();

        timeStamp = Time.time;
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
            timeStamp = Time.time + cooldown;

            
            
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
        }


        
    }

}
