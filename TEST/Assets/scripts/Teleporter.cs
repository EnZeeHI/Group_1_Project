using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour {


    public string Player;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);

        MovementP2 Player = hitInfo.GetComponent<MovementP2>();
        if (Player != null)
        {
            SceneManager.LoadScene("Level 2");
        }


        
    }

}
