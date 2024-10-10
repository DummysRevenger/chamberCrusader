using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class strongZombieAttack : MonoBehaviour
{

    private Animator theAnimator;

    private GameObject player;

    private bool attacking;

    private bool onCooldown;

    private meleeEnemy movementScript;

    private randomMovementAdvanced movementScript2;

    private GameObject attackObject;

    public GameObject attackSpawnPoint;

    private string attackPath;

    private float distanceThreshold = 4f;


    // Start is called before the first frame update
    void Start()
    {

        if (gameObject.name.Contains("fireDemon"))
        {
            theAnimator = GetComponent<Animator>();
        }
        

        player = GameObject.FindGameObjectWithTag("Player");

        if (gameObject.name.Contains("strongZombieSprite") || gameObject.name.Contains("fireDemon"))
        {
            movementScript = GetComponent<meleeEnemy>();
        }
        else if (gameObject.name.Contains("yetiDemon"))
        {
            movementScript2 = GetComponent<randomMovementAdvanced>();
        }




        if (gameObject.name.Contains("strongZombieSprite"))
        {
             attackPath = "Scenes/update11Resources/theonioncity/prefabs/strongZombieAttackObject";
        }
        else if (gameObject.name.Contains("fireDemon"))
        {
            attackPath = "Scenes/update12Resources/fireOfHeresy/fireDemonAttack";
        }
        else if (gameObject.name.Contains("yetiDemon"))
        {
            attackPath = "Scenes/update12Resources/treacherousIce/yetiDemonAttack";

            Debug.Log("yeti");

            distanceThreshold = 5f;
        }
        


        attackObject = Resources.Load(attackPath) as GameObject;

        Debug.Log(attackObject);

    }

    void startAttack()
    {

        Invoke("endAttack", 0.55f);

        if (gameObject.name.Contains("yetiDemon"))
        {
            Invoke("endCooldown", 5f);
        }
        else
        {
            Invoke("endCooldown", 2f);
        }
            

        

        

        onCooldown = true;

        if (gameObject.name.Contains("strongZombieSprite") || gameObject.name.Contains("fireDemon"))
        {
            movementScript.enabled = true;
        }
        else if (gameObject.name.Contains("yetiDemon"))
        {
            movementScript2.enabled = true;

            theAnimator.SetBool("attacking", true);
        }

        Instantiate(attackObject, attackSpawnPoint.transform.position, transform.rotation);


        if (!gameObject.name.Contains("fireDemon"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
        }

    }

    

    void endAttack()
    {
        

        attacking = false;

        if (gameObject.name.Contains("strongZombieSprite") || gameObject.name.Contains("fireDemon"))
        {
            movementScript.enabled = true;
        }
        else if (gameObject.name.Contains("yetiDemon"))
        {
            movementScript2.enabled = true;

            theAnimator.SetBool("attacking", false);
        }

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

        if (distanceFromPlayer < distanceThreshold && !attacking && !onCooldown)
        {
            attacking = true;
            startAttack();
        }

    }
}
