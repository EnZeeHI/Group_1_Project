using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour {


    public string Player;
    public string Player2;
    public GameObject teleporter2;
    public bool colliderP1 = false;
    public bool colliderP2 = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (colliderP1 && colliderP2)
        {
            SceneManager.LoadScene("Scene 1");
        }
	}

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);

        MovementP2 Player2 = hitInfo.GetComponent<MovementP2>();
        if (Player2 != null)
        {
            colliderP2 = true;
        }

        Movement Player = hitInfo.GetComponent<Movement>();
        if (Player != null)
        {
            colliderP1 = true;
        }



    }


   
}
