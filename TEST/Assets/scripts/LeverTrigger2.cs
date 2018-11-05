using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverTrigger2 : MonoBehaviour {
    public bool Colliding2;
    public bool TriggerActive;
    public AudioClip LeverClip;
	public AudioSource LeverSource;
   

    void OnTriggerStay2D(Collider2D other)
    {

        Colliding2 = true;

        var SpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        // checks enables and dissables the trigger, flips the sprite
        if (Input.GetButtonDown("Submit") && Colliding2 == true)
        {   
            LeverSource.Play();
            if (SpriteRenderer.flipX == false)
            {
                SpriteRenderer.flipX = true;
                TriggerActive = true;

            }
            else
            {
                SpriteRenderer.flipX = false;
                TriggerActive = false;
            }

        }




    }
    //function OnTriggerExit2D is called  when the coliders no longer overlap
    // makes that you cant use the trigger when you dont touch it
    void OnTriggerExit2D(Collider2D other)
    {

        Colliding2 = false;
    }

    // Use this for initialization
    void Start () {
		 LeverSource.clip = LeverClip;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
