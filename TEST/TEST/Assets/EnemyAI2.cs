using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyAI2 : MonoBehaviour {


    public float speed;
    public float stoppingDistance;
    public Transform target;
    public string player;
    Scene scene;

    // Use this for initialization
    void Start () {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        Scene scene = SceneManager.GetActiveScene();
    }
	
	// Update is called once per frame
	void Update () {

        if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {


        Movement player = hitInfo.GetComponent<Movement>();
        if (player != null)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }



    }

}
