using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pKnightChangeAnim : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rb2D;

    private void Start()
    {
        animator = GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    public void ChangeAnimation(int animationState)
    {
        animator.SetInteger("direction", animationState);
    }

    void Update()
    {
        if (rb2D.velocity.y < 0 ) // down
        {
            ChangeAnimation(2);
        }


        if (rb2D.velocity.y > 0) // up
        {
            ChangeAnimation(3);
        }


        if (rb2D.velocity.x > 0) // right
        {
            ChangeAnimation(4);
        }


        if (rb2D.velocity.x < 0 ) // left
        {
            ChangeAnimation(1);
        }
           
        

        
        
    }

}
