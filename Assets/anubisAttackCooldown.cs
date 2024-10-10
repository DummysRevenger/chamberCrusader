using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anubisAttackCooldown : MonoBehaviour
{


    public GameObject attackPrefab;

    private meleeEnemy movementScript;


    private Animator animator;

    public bool shouldAttack;

    private bool movementScriptDisabled = false;

    private void Start()
    {
        animator = GetComponent<Animator>();

        movementScript = GetComponent<meleeEnemy>();

        Invoke("attack", 3f);
    }



    void attack()
    {
        disableHurtBox();

        GameObject attackInstance = Instantiate(attackPrefab, transform);

        movementScriptDisabled = true;

        disableSprite();

        Invoke("enableSprite", 1f);

    }


    void enableSprite()
    {
        GetComponent<SpriteRenderer>().enabled = true;

        movementScript.enabled = true;

        enableHurtBox();

        movementScriptDisabled = false;

        Invoke("attack", 3f);
    }

    void disableSprite()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }

    void disableHurtBox()
    {
        GetComponent<BoxCollider2D>().enabled = false;
    }

    void enableHurtBox()
    {
        GetComponent<BoxCollider2D>().enabled = true;
    }



    // Update is called once per frame
    void Update()
    {
        if (GetComponent<hpStore>().health <= 0)
        {
            CancelInvoke("attack");
            CancelInvoke("enableSprite");
        }


        if(movementScriptDisabled)
        {
            movementScript.enabled = false;
        }

    }


}
