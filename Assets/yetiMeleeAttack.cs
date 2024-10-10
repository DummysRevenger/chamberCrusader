using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yetiMeleeAttack : MonoBehaviour
{

    private Animator theAnimator;

    private GameObject player;

    private bool attacking;

    private bool onCooldown;

    private meleeEnemy movementScript;

    private GameObject attackObject;

    public GameObject attackSpawnPoint;

    private string attackPath;


    // Start is called before the first frame update
    void Start()
    {
        theAnimator = GetComponent<Animator>();

        player = GameObject.FindGameObjectWithTag("Player");

        movementScript = GetComponent<meleeEnemy>();

        if (gameObject.name.Contains("strongZombieSprite"))
        {
            attackPath = "Scenes/update11Resources/theonioncity/prefabs/strongZombieAttackObject";
        }
        else if (gameObject.name.Contains("fireDemon"))
        {
            attackPath = "Scenes/update12Resources/fireOfHeresy/fireDemonAttack";
        }



        attackObject = Resources.Load(attackPath) as GameObject;

    }

    void startAttack()
    {
        Invoke("endAttack", 0.55f);

        Invoke("endCooldown", 2f);

        theAnimator.SetBool("attacking", true);

        onCooldown = true;

        movementScript.enabled = false;

        Instantiate(attackObject, attackSpawnPoint.transform.position, transform.rotation);

        GetComponent<SpriteRenderer>().enabled = false;

    }



    void endAttack()
    {
        theAnimator.SetBool("attacking", false);

        attacking = false;

        movementScript.enabled = true;

        GetComponent<SpriteRenderer>().enabled = true;

    }

    void endCooldown()
    {
        onCooldown = false;
    }

    // Update is called once per frame
    void Update()
    {
        float distanceFromPlayer = Vector3.Distance(transform.position, player.transform.position);

        if (distanceFromPlayer < 4f && !attacking && !onCooldown)
        {
            attacking = true;
            startAttack();
        }

    }
}
