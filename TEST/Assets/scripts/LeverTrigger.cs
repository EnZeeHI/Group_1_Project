using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverTrigger : MonoBehaviour {
public bool Colliding;
public bool TriggerActive;
	// void update(){
	// 	OnTriggerStay2D(Collider2D other);
	// }
	
	// function OnTriggerStay - is called when two colliders overlap
	// allows you to use the trigger if anything is touching it
		void OnTriggerStay2D (Collider2D other){
			
			 Colliding = true;
			
		 var SpriteRenderer  = gameObject.GetComponent<SpriteRenderer>();
		 // checks enables and dissables the trigger, flips the sprite
			 if (Input.GetButtonDown("Submit2") && Colliding==true){
				
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
	
	 


	
}