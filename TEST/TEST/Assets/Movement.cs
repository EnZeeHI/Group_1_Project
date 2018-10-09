using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    private float speed = 10;
    public int state = 0;

    public SpriteRenderer player1sprite;
    public SpriteRenderer player2sprite;
    public SpriteRenderer player1charachter;
    public Transform player1body;

    Animator myAnim;

    

	// Use this for initialization
	void Start () {
        myAnim = GetComponent<Animator>();

        player1sprite.enabled = true;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        pos.x += Input.GetAxisRaw("Horizontal1") * speed * Time.deltaTime;
        transform.position = pos;

        myAnim.SetInteger("state", (int)Input.GetAxisRaw("Horizontal1"));
        Debug.Log(state);

        Vector3 poss = transform.position;
        poss.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.position = poss;

        if (Input.GetButtonDown("swapGun1"))
        {
            player1sprite.enabled = false;
            player2sprite.enabled = true;
        }

        if ( Input.GetAxisRaw("Horizontal1") < 0)
        {
            player1body.Rotate(0f, 180f, 0f);
        }

        if(Input.GetAxisRaw("Horizontal1") > 0)
        {
            transform.Rotate(0f, 0f, 0f);
        }

    }
}
