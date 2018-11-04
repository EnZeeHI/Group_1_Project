using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementP2 : MonoBehaviour
{
    private float speed = 10;
    public int state = 0;
    public float height;

    public SpriteRenderer player1sprite;
    public SpriteRenderer player2sprite;
    public SpriteRenderer player2charachter;
    public bool facing = true;
    bool grounded = true;
    public AudioClip Jump2Clip;
    public AudioSource MusicSource;
    public AudioClip SwapGun2Clip;
    public AudioSource SwapSource;

    Animator myAnim;

    // Use this for initialization
    void Start()
    {
        myAnim = GetComponent<Animator>();

        player1sprite.enabled = true;
        MusicSource.clip = Jump2Clip;
        SwapSource.clip = SwapGun2Clip;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(grounded);

        if (Input.GetAxisRaw("Horizontal2") < 0 && facing)
        {
            facing = false;
            transform.Rotate(0, 180, 0);
        }

        if (Input.GetAxisRaw("Horizontal2") > 0 && !facing)
        {
            facing = true;
            transform.Rotate(0f, 180f, 0f);
        }

        if (Input.GetButtonDown("swapGun2"))
        {
            Debug.Log("boop");
            player1sprite.enabled = false;
            player2sprite.enabled = true;
            SwapSource.Play();
        }

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown("joystick 2 button 0"))
        {
            if (grounded)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, height);
                myAnim.SetBool("jumping2", true);
                MusicSource.Play();
            }
        }


        Vector3 pos = transform.position;
        pos.x += Input.GetAxisRaw("Horizontal2") * speed * Time.deltaTime;
        transform.position = pos;

        myAnim.SetInteger("walk", (int)Input.GetAxisRaw("Horizontal2"));
        


        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        grounded = true;
        myAnim.SetBool("jumping2", false);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        grounded = false;
    }
}