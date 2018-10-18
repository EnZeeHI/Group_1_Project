using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementP2 : MonoBehaviour
{
    private float speed = 10;
    public int state = 0;
    public float height;

    public SpriteRenderer player2sprite;
    public SpriteRenderer player1sprite;
    public SpriteRenderer player2charachter;
    public bool facing = true;
    bool grounded = true;

    Animator myAnim;

    // Use this for initialization
    void Start()
    {
        myAnim = GetComponent<Animator>();

        player2sprite.enabled = false;
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
            player2sprite.enabled = false;
            player1sprite.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (grounded)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, height);
            }
        }


        Vector3 pos = transform.position;
        pos.x += Input.GetAxisRaw("Horizontal2") * speed * Time.deltaTime;
        transform.position = pos;

        myAnim.SetInteger("state", (int)Input.GetAxisRaw("Horizontal2"));
        


        

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