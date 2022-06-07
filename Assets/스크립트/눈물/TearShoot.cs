using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TearShoot : MonoBehaviour
{
    Collider2D coll;
    Rigidbody2D RB;
    public float TearSpeed;
    public float MaxTearSpeed;
    void Start()
    {
        coll = GetComponent<Collider2D>();
        RB = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
