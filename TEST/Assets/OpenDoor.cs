using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour {


GameObject lever;
void DoorState(){
	Debug.Log("this works i guess");
lever =GameObject.Find("lever");
var leverTrigger = lever.GetComponent<LeverTrigger>();
Debug.Log(leverTrigger.switchState());
	
 if(leverTrigger.switchState() )
 Destroy(transform.parent.gameObject);
}
}
