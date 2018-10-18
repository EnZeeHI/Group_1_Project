using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour {

    public string player;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
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
