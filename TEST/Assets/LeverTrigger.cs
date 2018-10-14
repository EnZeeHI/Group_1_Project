using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverTrigger : MonoBehaviour {
public bool colliding;
public bool switchEnabled;
	
	

 		// this function checks if the object is colliding with anything
		void OnTriggerStay2D (Collider2D other){
			
			 colliding = true;
			
		 	var SpriteRenderer  = gameObject.GetComponent<SpriteRenderer>();
		 	//this statement checks if the key is pressed AND is colliding and then flips the switch sprite and gives a new value to switchState
			if (Input.GetKeyDown(KeyCode.F)&& colliding==true){
				if(SpriteRenderer.flipX== false){
				SpriteRenderer.flipX = true;
				switchEnabled= true;
				}
				else {
					SpriteRenderer.flipX = false;
					switchEnabled = false;
				}
			}
	
			

				
		}
		// this function checks if there if the objects are still coliding and returns a value 
		void OnTriggerExit2D(Collider2D other){
			
			colliding = false;
		}
		//this function returns variable switchEnabled, used to access the bool from different scripts
		public bool switchState(){
			return switchEnabled;
		}
		
	 
	

	
}
