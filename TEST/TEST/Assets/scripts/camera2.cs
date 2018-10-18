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
        if (Player2.position.x >= -37 && Player2.position.x <= 17)
        {
            transform.position = new Vector3(Player2.position.x, Player2.position.y, Player2.position.z);
        }
        else if (Player2.position.x <= 17)
        {
            transform.position = new Vector3(-37, Player2.position.y, Player2.position.z);
        }
        else if (Player2.position.x >= -37)
        {
            transform.position = new Vector3(17, Player2.position.y, Player2.position.z);
        }


    }
}
