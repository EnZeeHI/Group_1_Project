using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyAI2 : MonoBehaviour {


    public float speed;
    public float stoppingDistance;
    public Transform target;
    public string player;
    public bool dead;
    Scene scene;

    public float timeStamp;
    public float cooldown = 5;

    // Use this for initialization
    void Start () {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        Scene scene = SceneManager.GetActiveScene();

        timeStamp = Time.time;
    }
	
	// Update is called once per frame
	void Update () {
        if (dead == false)
        {
            if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }
        }

        if (dead == true)
        {
            if (timeStamp <= Time.time)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {


        Movement player = hitInfo.GetComponent<Movement>();
        if (player != null)
        {
            timeStamp = Time.time + cooldown;

            dead = true;

            Destroy(target.gameObject);
        }



    }

}
