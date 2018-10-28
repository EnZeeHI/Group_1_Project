using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour {

    public float speed = 20f;
    public Rigidbody2D rb;
    public string enemy;

    // Use this for initialization
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);

        EnemyAI2 enemy = hitInfo.GetComponent<EnemyAI2>();
        if (enemy != null)
        {
            Destroy(enemy.gameObject);
        }

        Destroy(gameObject);
    }

}
