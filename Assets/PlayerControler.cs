using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    float xdir;
    public float speed = 5f;

    public float jumpForce = 7f;


    Rigidbody2D rb;
    Animator anim;
    SpriteRenderer spr;

    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spr = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        xdir = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(xdir * speed, rb.velocity.y);

        if (xdir != 0){
            anim.SetBool("Running", true);
            if (xdir < 0) {
                spr.flipX = true;
            } else {
                spr.flipX = false;
            }

    } else {
        anim.SetBool("Running", false);
    }
    
    if(Input.GetKeyUp(KeyCode.Space)) {

            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            
        }
    }
}