using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prideGetPridefulAbility : MonoBehaviour
{
    private bool isCooldown = false;
    private float cooldownDuration = 15f; // Cooldown duration in seconds
    public float cooldownTimer = 0.0f;
    private AudioSource audioSource;
    public static prideGetPridefulAbility S;
    private SpriteRenderer playerSprite;
    public bool abilityRunning = false;

    public GameObject cross2;

    // Start is called before the first frame update
    void Start()
    {
        S = this;
        audioSource = GetComponent<AudioSource>();

        playerSprite = GetComponent<SpriteRenderer>();




    }

    void endAbility()
    {
        //change damage multiplier back to 1

        //change player colour back to normal


        nextRoomChecker.S.projectileDamage *= 2;

        nextRoomChecker.S.meleeDamage *= 2;

        nextRoomChecker.S.enemyMovementSpeed *= 2;





        // Get all game objects with the tag "enemy"
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");

        // Iterate through the array and do something with each enemy
        foreach (GameObject enemy in enemies)
        {
            Debug.Log("Found enemy: " + enemy.name);
            // You can perform other actions with the enemy object here

            if (enemy.GetComponent<hpStore>() != null)
            {
                enemy.GetComponent<hpStore>().health *= 2;
            }



            if (enemy.GetComponent<meleeEnemy>() != null)
            {
                enemy.GetComponent<meleeEnemy>().movementSpeed *= 2;
            }

            if (enemy.GetComponent<rangedEnemy>() != null)
            {
                enemy.GetComponent<rangedEnemy>().chaseSpeed *= 2;
                enemy.GetComponent<rangedEnemy>().retreatSpeed *= 2;
            }


            if (enemy.GetComponent<rangedEnemy>() != null)
            {
                enemy.GetComponent<rangedEnemy>().chaseSpeed *= 2;
                enemy.GetComponent<rangedEnemy>().retreatSpeed *= 2;
            }

            if (enemy.GetComponent<ghostDragon>() != null)
            {
                enemy.GetComponent<ghostDragon>().movementSpeed *= 2;
            }


            if (enemy.GetComponent<jumpAtPlayer>() != null)
            {
                enemy.GetComponent<jumpAtPlayer>().movementSpeed *= 2;
            }

            if (enemy.GetComponent<spiderJumpAtPlayer>() != null)
            {
                enemy.GetComponent<spiderJumpAtPlayer>().jumpCooldown *= 2;

            }

        }



    }


    // Update is called once per frame
    void Update()
    {


        audioSource.clip = playerAudioStore.S.audioClips[2];



        if (!isCooldown && (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Y)))
        {

            // Get all game objects with the tag "enemy"
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");

            audioSource.clip = playerAudioStore.S.audioClips[2];
            audioSource.Play(); // Play the clip

            // Iterate through the array and do something with each enemy
            foreach (GameObject enemy in enemies)
            {
                Debug.Log("Found enemy: " + enemy.name);
                // You can perform other actions with the enemy object here

                if (enemy.GetComponent<hpStore>() != null)
                {
                    enemy.GetComponent<hpStore>().health /= 2;
                }

                if (enemy.GetComponent<meleeEnemy>() != null)
                {
                    enemy.GetComponent<meleeEnemy>().movementSpeed /= 2;
                }

                if (enemy.GetComponent<rangedEnemy>() != null)
                {
                    enemy.GetComponent<rangedEnemy>().chaseSpeed /= 2;
                    enemy.GetComponent<rangedEnemy>().retreatSpeed /= 2;
                }


                if (enemy.GetComponent<rangedEnemy>() != null)
                {
                    enemy.GetComponent<rangedEnemy>().chaseSpeed /= 2;
                    enemy.GetComponent<rangedEnemy>().retreatSpeed /= 2;
                }

                if (enemy.GetComponent<ghostDragon>() != null)
                {
                    enemy.GetComponent<ghostDragon>().movementSpeed /= 2;
                }


                if (enemy.GetComponent<jumpAtPlayer>() != null)
                {
                    enemy.GetComponent<jumpAtPlayer>().movementSpeed /= 2;
                }

                if (enemy.GetComponent<spiderJumpAtPlayer>() != null)
                {
                    enemy.GetComponent<spiderJumpAtPlayer>().jumpCooldown /= 2;
                    
                }

                // get all movement scripts
                // ranged enemy
                // jump at player
                // spider jump at player
                // ghost dragon

            }


            nextRoomChecker.S.projectileDamage /= 2;

            nextRoomChecker.S.meleeDamage /= 2;

            

            




            cross2.SetActive(true);



            abilityRunning = true;



            

            cooldownTimer = 15f;
            isCooldown = true;

            Invoke("endAbility", 5f);



        }

        if (isCooldown)
        {

            if (enemiesInRoomChecker.S.enemiesInRoomNumber > 0)
            {
                cooldownTimer -= Time.deltaTime;
            }

            if (cooldownTimer <= 0.0f)
            {
                // Cooldown is over
                isCooldown = false;

                cross2.SetActive(false);

            }
        }

      


    }
}
