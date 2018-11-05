using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyAI : MonoBehaviour {

    public float speed;
    public float stoppingDistance;
    public Transform target;
    public string player;
    public bool dead = false;
    Scene scene;
    public AudioClip DeathClip;
	public AudioSource DeathSource;
    public AudioClip EnemyDeathClip;
    public AudioSource EnemyDeathSource;

    public float timeStamp;
    public float cooldown = 5;



    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player2").GetComponent<Transform>();

        Scene scene = SceneManager.GetActiveScene();
        
        DeathSource.clip = DeathClip;
        EnemyDeathSource.clip=EnemyDeathClip;

        timeStamp = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(dead);
       // Debug.Log(timeStamp);
        if (dead == false)
        {
            if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }
        }

        if (dead == true)
        {
            EnemyDeathSource.Play();
            if (timeStamp <= Time.time)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        

        MovementP2 player = hitInfo.GetComponent<MovementP2>();
        if (player != null)
        {
            timeStamp = Time.time + cooldown;
            DeathSource.Play();
            dead = true;
            
            Destroy(target.gameObject);
            
                
            
        }


        
    }

}
