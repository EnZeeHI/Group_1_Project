using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraplayer1scene2 : MonoBehaviour {

    public Transform Player1;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Player1.position.x >= -15 && Player1.position.x <= 93)
        {
            transform.position = new Vector3(Player1.position.x, Player1.position.y, Player1.position.z);
        }
        else if (Player1.position.x <= 93)
        {
            transform.position = new Vector3(-15, Player1.position.y, Player1.position.z);
        }
        else if (Player1.position.x >= -15)
        {
            transform.position = new Vector3(93, Player1.position.y, Player1.position.z);
        }

    }
}
