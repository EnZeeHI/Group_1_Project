using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnplayer2 : MonoBehaviour {

    public GameObject Player2;
    public Transform spawnpoint;
	// Use this for initialization
	void Start () {
        Instantiate(Player2, spawnpoint.position, spawnpoint.rotation);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
