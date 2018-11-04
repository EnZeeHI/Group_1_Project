using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeScript : MonoBehaviour {
public bool Colliding;
public bool TriggerActiveBridge = false;
//public GameObject Bridge;
//private Bridge BridgeComponent;
	
	void Start(){
	
		
	}
	void Update(){
		//Debug.Log("Update");
		ObjectEnable();
        //Debug.Log(TriggerActiveBridge);
	}
	
	// function OnTriggerStay - is called when two colliders overlap
	// allows you to use the trigger if anything is touching it
		void OnTriggerStay2D (Collider2D other){
			
			 Colliding = true;
			
		 var SpriteRenderer  = gameObject.GetComponent<SpriteRenderer>();
		 
		 // checks enables and dissables the trigger, flips the sprite
			 if (Input.GetButtonDown("Submit")&& Colliding==true){
				
					 if(SpriteRenderer.flipX== false){
					SpriteRenderer.flipX = true;
					TriggerActiveBridge = true;
					
					}
					else {
						SpriteRenderer.flipX = false;
						TriggerActiveBridge = false;
						}
						
				}
	
			

				
		}
		//function OnTriggerExit2D is called  when the coliders no longer overlap
		// makes that you cant use the trigger when you dont touch it
		void OnTriggerExit2D(Collider2D other){
			
			Colliding = false;
		}
		void ObjectEnable(){
			GameObject Bridge = GameObject.Find("Bridge");
			var BridgeSpriteRenderer = 	Bridge.GetComponent<SpriteRenderer>();
			var BridgeBoxCollider = Bridge.GetComponent<BoxCollider2D>();
			
			if (TriggerActiveBridge == true ){
			 	//Debug.Log("full");
            //Debug.Log(TriggerActiveBridge);
			BridgeSpriteRenderer.enabled = true;
			BridgeBoxCollider.enabled = true;
			
			}
			if (TriggerActiveBridge == false){
            //Debug.Log("off");
            //Debug.Log(TriggerActiveBridge);
			 BridgeSpriteRenderer.enabled = false;
			 BridgeBoxCollider.enabled = false;
			
			}
			
			
		}
	
	 


	
}
