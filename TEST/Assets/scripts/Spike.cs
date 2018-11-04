using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spike : MonoBehaviour {

    public string player;
    public bool dead;
    Scene scene;

    public float timeStamp;
    public float cooldown = 5;

    // Use this for initialization
    void Start () {
        Scene scene = SceneManager.GetActiveScene();

        timeStamp = Time.time;
    }
	
	// Update is called once per frame
	void Update () {

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


        MovementP2 player = hitInfo.GetComponent<MovementP2>();
        if (player != null)
        {
            timeStamp = Time.time + cooldown;

            dead = true;

            Destroy(player.gameObject);
        }

        Movement player1 = hitInfo.GetComponent<Movement>();
        if (player1 != null)
        {
            timeStamp = Time.time + cooldown;

            dead = true;

            Destroy(player1.gameObject);
        }

    }
}
