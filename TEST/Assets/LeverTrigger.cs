using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverTrigger : MonoBehaviour {
 public bool colliding;


		void OnTriggerEnter2D(Collider2D other){
				

    		//Debug.Log(other.name);
			//Debug.Log("Object entered a trigger");

		}
		void OnTriggerStay2D (Collider2D other){
			//Debug.Log("object is within the trigger");
			// var gameObject = GameObject;
			 colliding = true;
			
		 var SpriteRenderer  = gameObject.GetComponent<SpriteRenderer>();
			 if (Input.GetKeyDown(KeyCode.F)&& colliding==true){
					 if(SpriteRenderer.flipX== false){
					SpriteRenderer.flipX = true;
					}
					else {
						SpriteRenderer.flipX = false;
						}
				}
	
			

				
		}
		void OnTriggerExit2D(Collider2D other){
			//Debug.Log("object is within the trigger");
			colliding = false;
		}
		
	 
	// void update(){
	// 	 var SpriteRenderer  = gameObject.GetComponent<SpriteRenderer>();
	// 		 if (Input.GetKeyDown(KeyCode.F)&& colliding==true)
	// 			{ 
	// 				SpriteRenderer.flipX = true;
	// 			}
	// }

	
}
