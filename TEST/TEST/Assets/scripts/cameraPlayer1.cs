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
        if (Player1.position.x >= -37 && Player1.position.x <= 17)
        {
            transform.position = new Vector3(Player1.position.x, Player1.position.y, Player1.position.z);
        }
        else if (Player1.position.x <= 17)
        {
            transform.position = new Vector3(-37, Player1.position.y, Player1.position.z);
        }
        else if (Player1.position.x >= -37)
        {
            transform.position = new Vector3(17, Player1.position.y, Player1.position.z);
        }
    }
}
