using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallLever : MonoBehaviour {
    public bool WallColliding;
    public bool TriggerActiveWall = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ObjectEnable();
    }

    void OnTriggerStay2D(Collider2D other)
    {

        WallColliding = true;

        var SpriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        // checks enables and dissables the trigger, flips the sprite
        if (Input.GetButtonDown("Submit") && WallColliding == true)
        {

            if (SpriteRenderer.flipX == false)
            {
                SpriteRenderer.flipX = true;
                TriggerActiveWall = true;

            }
            else
            {
                SpriteRenderer.flipX = false;
                TriggerActiveWall = false;
            }

        }




    }
    //function OnTriggerExit2D is called  when the coliders no longer overlap
    // makes that you cant use the trigger when you dont touch it
    void OnTriggerExit2D(Collider2D other)
    {

        WallColliding = false;
    }
    void ObjectEnable()
    {
        GameObject Wall = GameObject.Find("Wall");
        var WallSpriteRenderer = Wall.GetComponent<SpriteRenderer>();
        var WallBoxCollider = Wall.GetComponent<BoxCollider2D>();

        if (TriggerActiveWall == true)
        {
            //Debug.Log("full");
            //Debug.Log(TriggerActiveBridge);
            WallSpriteRenderer.enabled = false;
            WallBoxCollider.enabled = false;

        }
        if (TriggerActiveWall == false)
        {
            //Debug.Log("off");
            //Debug.Log(TriggerActiveBridge);
            WallSpriteRenderer.enabled = true;
            WallBoxCollider.enabled = true;

        }


    }

}
