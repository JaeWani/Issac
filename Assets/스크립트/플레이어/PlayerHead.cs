using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHead : MonoBehaviour
{
    SpriteRenderer sprite;
    Animator Anim;
    void Start()
    {
        Anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

   
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            Anim.SetBool("RIGHTATTACK", true);
        else
            Anim.SetBool("RIGHTATTACK", false);  

        if (Input.GetKey(KeyCode.UpArrow))
            Anim.SetBool("UPATTACK", true);
        else
            Anim.SetBool("UPATTACK", false);

        if (Input.GetKey(KeyCode.DownArrow))
            Anim.SetBool("DOWNATTACK", true);
        else
            Anim.SetBool("DOWNATTACK", false);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Anim.SetBool("LEFTATTACK", true);
        }
        else
        {
            Anim.SetBool("LEFTATTACK", false);
            sprite.flipX = false;
        }
    }
}
