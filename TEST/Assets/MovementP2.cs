using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementP2 : MonoBehaviour
{
    private float speed = 10;
    public int state = 0;

    public SpriteRenderer player2sprite;
    public SpriteRenderer player1sprite;
    public SpriteRenderer player2charachter;

    Animator myAnim;

    // Use this for initialization
    void Start()
    {
        myAnim = GetComponent<Animator>();

        player2sprite.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.GetAxisRaw("Horizontal2"));

        if (Input.GetAxisRaw("Horizontal2") < 0)
        {
            Debug.Log("yay");
            player2charachter.flipX = true;
        }

        if (Input.GetAxisRaw("Horizontal2") > 0)
        {
            player2charachter.flipX = false;
        }

        if (Input.GetButtonDown("swapGun2"))
        {
            Debug.Log("boop");
            player2sprite.enabled = false;
            player1sprite.enabled = true;
        }


        Vector3 pos = transform.position;
        pos.x += Input.GetAxisRaw("Horizontal2") * speed * Time.deltaTime;
        transform.position = pos;

        myAnim.SetInteger("state", (int)Input.GetAxisRaw("Horizontal2"));
        Debug.Log(state);


        

    }
}