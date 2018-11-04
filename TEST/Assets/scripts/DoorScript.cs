using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

	void Update(){
		DoorState();
	}



	// function DoorState opens and closes the door
	void DoorState( ){
		//finding the lever game object and accesing its script
		var LeverBool = GameObject.Find("Lever").GetComponent<LeverTrigger>();
		
		if (LeverBool.TriggerActive==true){
			// destroys the door
			Destroy(this.gameObject);
		}
		else{
			// this will be filled in later
		}
	}

}