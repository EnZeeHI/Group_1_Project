using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera2 : MonoBehaviour {

    public Transform Player2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Player2.position.x >= -15 && Player2.position.x <= -5)
        {
            transform.position = new Vector3(Player2.position.x, 15, Player2.position.z);
        }
        else if (Player2.position.x <= -5)
        {
            transform.position = new Vector3(-15, 15, Player2.position.z);
        }
        else if (Player2.position.x >= -15)
        {
            transform.position = new Vector3(-5, 15, Player2.position.z);
        }


    }
}
