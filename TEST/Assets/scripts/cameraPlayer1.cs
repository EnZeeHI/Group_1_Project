using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPlayer1 : MonoBehaviour {

    public Transform Player1;
    public int MaxX;
    public int MinX;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Player1.position.x >= MinX && Player1.position.x <= MaxX)
        {
            transform.position = new Vector3(Player1.position.x, -6, Player1.position.z);
        }
        else if (Player1.position.x <= MaxX)
        {
            transform.position = new Vector3(MinX, -6, Player1.position.z);
        }
        else if (Player1.position.x >= MinX)
        {
            transform.position = new Vector3(MaxX, -6, Player1.position.z);
        }
    }
}
