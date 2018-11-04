using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptcamerep2s2 : MonoBehaviour {

    public Transform Player2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Player2.position.x >= -15 && Player2.position.x <= 93)
        {
            transform.position = new Vector3(Player2.position.x, Player2.position.y, Player2.position.z);
        }
        else if (Player2.position.x <= 93)
        {
            transform.position = new Vector3(-15, Player2.position.y, Player2.position.z);
        }
        else if (Player2.position.x >= -15)
        {
            transform.position = new Vector3(93, Player2.position.y, Player2.position.z);
        }

    }
}
