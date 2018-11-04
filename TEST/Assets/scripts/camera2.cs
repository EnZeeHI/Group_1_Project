using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera2 : MonoBehaviour {

    public Transform Player2;
    public int MaxX;
    public int MinX;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Player2.position.x >= MinX && Player2.position.x <= MaxX)
        {
            transform.position = new Vector3(Player2.position.x, 15, Player2.position.z);
        }
        else if (Player2.position.x <= MaxX)
        {
            transform.position = new Vector3(MinX, 15, Player2.position.z);
        }
        else if (Player2.position.x >= MinX)
        {
            transform.position = new Vector3(MaxX, 15, Player2.position.z);
        }


    }
}
