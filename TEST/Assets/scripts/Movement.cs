using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    private float speed = 10;
    public int state = 0;
    public float height;

    public SpriteRenderer player1sprite;
    public SpriteRenderer player2sprite;
    public SpriteRenderer player1charachter;
    public Transform player1body;
    public bool facing = true;
    bool grounded = true;

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
        

        
        

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (grounded)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, height);
            }
        }

        if (Input.GetButtonDown("swapGun1"))
        {
            player1sprite.enabled = false;
            player2sprite.enabled = true;
        }

        if (Input.GetAxisRaw("Horizontal1") < 0 && facing)
        {
            facing = false;
            player1body.Rotate(0, 180, 0);
        }

        if(Input.GetAxisRaw("Horizontal1") > 0 && !facing)
        {
            facing = true;
            transform.Rotate(0f, 180f, 0f);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        grounded = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        grounded = false;
    }

}
