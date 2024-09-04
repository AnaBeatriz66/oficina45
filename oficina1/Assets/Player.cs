using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed;
    public float jumpForce;

    public bool isJumping = false;
    public bool doublejump;
    private Rigidbody2D rig;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        jump();
    }

    void Move()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * (Time.deltaTime * Speed);

        if (Input.GetAxis("Horizontal") > 0f)
        {
            anim.SetBool("walk", true);
            transform.localEulerAngles = new Vector3(0f, 0f, 0f);
        }

        if (Input.GetAxis("Horizontal") < 0f)
        {
            anim.SetBool("walk", true);
            transform.localEulerAngles = new Vector3(0f, 180f, 0f);
        }

        if (Input.GetAxis("Horizontal") == 0f)
        {
            anim.SetBool("walk", false);
        }
    }

    void jump()
        {
            if (Input.GetButtonDown("Jump"))
            {
                if (!isJumping)
                {
                    anim.SetBool("jump",true);
                    rig.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
                    doublejump = true;
                }
                else
                {
                    if (doublejump)
                    {
                        anim.SetBool("jump",true);
                        rig.AddForce(new Vector2(0f, jumpForce * 2f), ForceMode2D.Impulse);
                        doublejump = false;
                    }
                }

            }

        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.layer == 8)
            {
                isJumping = false;
                anim.SetBool("jump",false);
            }

            if (collision.gameObject.tag == "Spike")
            {
               GameController.instance.ShowGameOver();
               Destroy(gameobject);
            }

        }

        void OnCollisionExit2D(Collision2D collision)
        {

            if (collision.gameObject.layer == 8)
            {
                isJumping = true;

            }
        }
    }




