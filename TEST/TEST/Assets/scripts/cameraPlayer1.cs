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

        transform.position = new Vector3 (Player1.position.x , Player1.position.y);

    }
}
