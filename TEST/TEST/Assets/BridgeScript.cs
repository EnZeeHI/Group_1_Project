using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeScript : MonoBehaviour {
public bool Colliding;
public bool TriggerActive;
//public GameObject Bridge;
//private Bridge BridgeComponent;
	
	void Start(){
	
		
	}
	void Update(){
		Debug.Log("Update");
		ObjectEnable();
	}
	
	// function OnTriggerStay - is called when two colliders overlap
	// allows you to use the trigger if anything is touching it
		void OnTriggerStay2D (Collider2D other){
			
			 Colliding = true;
			
		 var SpriteRenderer  = gameObject.GetComponent<SpriteRenderer>();
		 
		 // checks enables and dissables the trigger, flips the sprite
			 if (Input.GetKeyDown(KeyCode.F)&& Colliding==true){
				
					 if(SpriteRenderer.flipX== false){
					SpriteRenderer.flipX = true;
					TriggerActive = true;
					
					}
					else {
						SpriteRenderer.flipX = false;
						TriggerActive = false;
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
			
			if (TriggerActive==true ){
			// 	Debug.Log("full");
			BridgeSpriteRenderer.enabled= true;
			BridgeBoxCollider.enabled = true;
			
			}
			else{
			 BridgeSpriteRenderer.enabled = false;
			 BridgeBoxCollider.enabled = false;
			
			}
			
			
		}
	
	 


	
}
