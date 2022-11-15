using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D Rb;
    private bool jump;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //when velocity of the player in y direction is greater than 1f then it jumps
        if (Rb.velocity.y > 1f)
        {
            anim.SetInteger("state", 1);
            jump =true;
        }
        else if (Rb.velocity.y < 0f && jump == true) //when velocity of the player in y direction is less than 0f then it falls
        {
            anim.SetInteger("state", 2);
        }
        else //default state of running
        {
            anim.SetInteger("state", 0);
        }

    }
} 