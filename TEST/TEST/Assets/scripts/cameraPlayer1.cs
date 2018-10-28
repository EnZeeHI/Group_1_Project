using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPlayer1 : MonoBehaviour {

    public Transform Player1;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Player1.position.x >= -15 && Player1.position.x <= -5)
        {
            transform.position = new Vector3(Player1.position.x, -6, Player1.position.z);
        }
        else if (Player1.position.x <= -5)
        {
            transform.position = new Vector3(-15, -6, Player1.position.z);
        }
        else if (Player1.position.x >= -15)
        {
            transform.position = new Vector3(-5, -6, Player1.position.z);
        }
    }
}
