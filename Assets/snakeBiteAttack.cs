using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snakeBiteAttack : MonoBehaviour
{

    public SpriteRenderer orbitSprite;

    public OrbitPlayer orbitScript;

    public Transform player;

    private float moveSpeed = 7f;

    public GameObject openMouth;

    private GameObject openMouthInstance;

    public GameObject biteDown;

    public GameObject biteDownInstance;

    private hpStore snakeHPStore;

    public bool attacking;

    private Animator theAnimator;

    // Start is called before the first frame update
    void Start()
    {

        theAnimator = GetComponent<Animator>();


        orbitScript = GetComponent<OrbitPlayer>();

        

        snakeHPStore = GetComponent<hpStore>();


        if (gameObject.name.Contains("Chain"))
        {


            


            openMouth = GameObject.Find("chain snake bite anim_0");

            biteDown = GameObject.Find("snake bite down anim_0");
        }

        player = GameObject.FindGameObjectWithTag("Player").transform;



        if (gameObject.name.Contains("Chain"))
        {
            

            
            //openMouthInstance = Instantiate(openMouth, transform);

            theAnimator.SetBool("attacking", true);



            
        }

        



    }

    public void reStart()
    {

        if (gameObject.name.Contains("Chain"))
        {

            openMouth = GameObject.Find("chain snake bite anim_0");

            biteDown = GameObject.Find("snake bite down anim_0");
        }


        if (biteDownInstance != null)
        {
            //Destroy(biteDownInstance);
        }

        if (openMouthInstance != null)
        {
            //Destroy(openMouthInstance);
        }

        attacking = true;

        

        if (gameObject.name.Contains("Chain"))
        {
            //openMouthInstance = Instantiate(openMouth, transform);

            //theAnimator.SetBool("attacking", true);

            
        }

        orbitScript.enabled = false;

    }

    void reEnableOrbitScript()
    {



        if (gameObject.name.Contains("Chain"))
        {
            theAnimator.SetBool("attacking", false);
            //Destroy(openMouthInstance);
        }

        orbitSprite.enabled = true;

        orbitScript.scriptRestart = true;

        orbitScript.startPosCalculated = false;

        orbitScript.enabled = true;

        orbitScript.invokeBiteAttack();

        

        
    }



    void destroyBiteDownInstance()
    {
        //Destroy(biteDownInstance);

        orbitSprite.enabled = true;

    }

    void InstantBiteDown()
    {
        if (gameObject.name.Contains("Chain"))
        {
            //Destroy(openMouthInstance);
            // create an instance of the bite down animation
            //biteDownInstance = Instantiate(biteDown, transform);


            theAnimator.SetTrigger("biteDown");

            theAnimator.SetBool("attacking", false);

            Invoke("destroyBiteDownInstance", 0.4f);

            
        }


        attacking = false;


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("sword") || (other.gameObject.CompareTag("bullet") && !other.gameObject.name.Contains("chain")) )
        {

            InstantBiteDown();

            
            reEnableOrbitScript();

        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.CompareTag("Player"))
        {

            if (gameObject.name.Contains("Chain") && attacking)
            {
                //if (openMouthInstance != null)
                //{
                    InstantBiteDown();
                //}

                hpStorePlayer.S.playerHealth -= 350 * playerDamageTakenMultiplierStore.damageMultiplier;

                Invoke("reEnableOrbitScript", 0.5f);

                attacking = false;
            }

            if (gameObject.name.Contains("crawlingSnake"))
            {
                hpStorePlayer.S.playerHealth -= 100 * playerDamageTakenMultiplierStore.damageMultiplier;

                Invoke("reEnableOrbitScript", 0.5f);
            }
            
            
        }


    }


   

        // Update is called once per frame
        void Update()
        {
        theAnimator = GetComponent<Animator>();

        if (snakeHPStore.health <= 0)
            {

             if (gameObject.name.Contains("Chain"))
             {
                 if (openMouthInstance != null)
                 {
                        //Destroy(openMouthInstance);

                 }

                    if (biteDownInstance != null)
                    {
                        //Destroy(biteDownInstance);
                    }
                }
            }


        if (gameObject.name.Contains("Chain"))
        {

            openMouth = GameObject.Find("chain snake bite anim_0");

            biteDown = GameObject.Find("snake bite down anim_0");
        }


        

        if (attacking)
        {

            theAnimator.SetBool("attacking", true);


            player = GameObject.FindGameObjectWithTag("Player").transform;

            transform.position = Vector3.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);

            // make the object face the player

            // Get the direction from the current position to the player position
            Vector3 direction = player.position - transform.position;

            // Calculate the angle of rotation in radians
            float angle = Mathf.Atan2(direction.y, direction.x);

            // Create a rotation quaternion with only Z rotation
            Quaternion rotation = Quaternion.Euler(0f, 0f, angle * Mathf.Rad2Deg - 90);

            // Apply the rotation to the object
            transform.rotation = rotation;
        }





        if (gameObject.name.Contains("Chain"))
        {
            if (openMouthInstance != null)
            {
                
                openMouthInstance.transform.position = transform.position;
                openMouthInstance.transform.rotation = transform.rotation;

            }

            if (biteDownInstance != null)
            {
                
                biteDownInstance.transform.position = transform.position;
                biteDownInstance.transform.rotation = transform.rotation;
            }
        }


            // make the open mouth instance face the player
            //openMouthInstance.transform.LookAt(positionToLookAt);






        }
    }

