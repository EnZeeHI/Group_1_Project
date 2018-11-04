using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    private float speed = 10;
    public int state = 0;
    public float height;

    public SpriteRenderer player2sprite;
    public SpriteRenderer player1sprite;
    public SpriteRenderer player1charachter;
    public Transform player1body;
    public bool facing = true;
    bool grounded = true;
    public AudioClip JumpClip;
    public AudioSource MusicSource;
    public AudioClip SwapGunClip;
    public AudioSource SwapSource;

    Animator myAnim;

    

	// Use this for initialization
	void Start () {
        myAnim = GetComponent<Animator>();

        player2sprite.enabled = false;
        MusicSource.clip = JumpClip;
        SwapSource.clip = SwapGunClip;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        pos.x += Input.GetAxisRaw("Horizontal1") * speed * Time.deltaTime;
        transform.position = pos;

        myAnim.SetInteger("state", (int)Input.GetAxisRaw("Horizontal1"));





        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown("joystick 3 button 0"))
        {
            if (grounded)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, height);
                myAnim.SetBool("jumping", true);
                MusicSource.Play();
            }
        }

        if (Input.GetButtonDown("swapGun1"))
        {
            player2sprite.enabled = false;
            player1sprite.enabled = true;
            SwapSource.Play();
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
        myAnim.SetBool("jumping", false);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        grounded = false;
    }

}
