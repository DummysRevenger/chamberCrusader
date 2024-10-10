using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frogAttack : MonoBehaviour
{

   // private Animator theAnimator;

    private GameObject player;

    private bool attacking;

    private bool onCooldown;

    private spiderJumpAtPlayer movementScript;

    private GameObject attackObject;

    public GameObject attackSpawnPoint;

    

    

    private Animator animationComponent;

    


    private string attackPath;

    // Start is called before the first frame update
    void Start()
    {


        animationComponent = GetComponent<Animator>();

        player = GameObject.FindGameObjectWithTag("Player");

        movementScript = GetComponent<spiderJumpAtPlayer>();


        if (gameObject.name.Contains("giantFrog"))
        {
            attackPath = "Scenes/update12Resources/swamp/giantFrogAttackObject";
        }
        else if (gameObject.name.Contains("crocodile"))
        {
            attackPath = "Scenes/update12Resources/swamp/crocodileAttackObject";
        }
        

        attackObject = Resources.Load(attackPath) as GameObject;

    }

    void startAttack()
    {
        Invoke("endAttack", 0.55f);

        Invoke("endCooldown", 2f);

        //theAnimator.SetBool("attacking", true);

        onCooldown = true;

        movementScript.enabled = false;

        Instantiate(attackObject, attackSpawnPoint.transform.position, transform.rotation);

        

        GetComponent<SpriteRenderer>().enabled = false;

        GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 0f, 0f);

    }



    void endAttack()
    {
        //theAnimator.SetBool("attacking", false);

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


        if (distanceFromPlayer < 7f)
        {
            
            if (gameObject.name.Contains("crocodile"))
            {
                // play appear anim

                

                animationComponent.SetBool("crocodileAppear", true);


            }
        }
        else
        {
            if (gameObject.name.Contains("crocodile"))
            {
                



                animationComponent.SetBool("crocodileAppear", false);




            }
        }

    }
}
