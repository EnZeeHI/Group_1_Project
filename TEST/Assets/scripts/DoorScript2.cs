using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript2 : MonoBehaviour {

    

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        DoorState();
    }

    void DoorState()
    {
        //finding the lever game object and accesing its script
        var LeverBool = GameObject.Find("LeverP1").GetComponent<LeverTrigger2>();

        if (LeverBool.TriggerActive == true)
        {
            // destroys the door
            Destroy(this.gameObject);
        }
        else
        {
            // this will be filled in later
        }
    }

}
