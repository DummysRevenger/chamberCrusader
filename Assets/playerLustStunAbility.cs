using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLustStunAbility : MonoBehaviour
{

    private bool isCooldown = false;
    private float cooldownDuration = 15f; // Cooldown duration in seconds
    public float cooldownTimer = 0.0f;
    public static playerLustStunAbility S;

    

    public GameObject cross1;



    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        S = this;

        audioSource = GetComponent<AudioSource>();

    }


    void reEnableMovement()
    {

        GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");

        foreach (GameObject enemy in enemies)
        {
            if (enemy.gameObject.GetComponent<meleeEnemy>() != null)
            {
                enemy.gameObject.GetComponent<meleeEnemy>().Webbed = false;


            }
            else if (enemy.gameObject.GetComponent<rangedEnemy>() != null)
            {
                enemy.gameObject.GetComponent<rangedEnemy>().enabled = true;
            }
            else if (enemy.gameObject.GetComponent<randomMovementAdvanced>() != null)
            {
                enemy.gameObject.GetComponent<randomMovementAdvanced>().enabled = true;



                enemy.gameObject.GetComponent<randomMovementAdvanced>().Webbed = false;
            }
            else if (enemy.gameObject.GetComponent<jumpAtPlayer>() != null)
            {
                enemy.gameObject.GetComponent<jumpAtPlayer>().enabled = true;
            }
            else if (enemy.gameObject.GetComponent<spiderJumpAtPlayer>() != null)
            {
                enemy.gameObject.GetComponent<spiderJumpAtPlayer>().enabled = true;
            }
        }
    }



    void Update()
    {
        if (!isCooldown && (Input.GetKeyDown(KeyCode.Y) || Input.GetKeyDown(KeyCode.E)))
        {


            audioSource.clip = playerAudioStore.S.audioClips[3];
            audioSource.Play(); // Play the clip



            GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");

            foreach (GameObject enemy in enemies)
            {
                if (enemy.GetComponent<meleeEnemy>() != null)
                {


                    enemy.gameObject.GetComponent<meleeEnemy>().Webbed = true;



                }
                else if (enemy.gameObject.GetComponent<rangedEnemy>() != null)
                {
                    enemy.gameObject.GetComponent<rangedEnemy>().enabled = false;
                }
                else if (enemy.GetComponent<randomMovementAdvanced>() != null)
                {

                    enemy.gameObject.GetComponent<randomMovementAdvanced>().Webbed = true;

                    enemy.gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;


                    enemy.gameObject.GetComponent<randomMovementAdvanced>().enabled = false;




                }
                else if (enemy.GetComponent<jumpAtPlayer>() != null)
                {
                    enemy.gameObject.GetComponent<jumpAtPlayer>().enabled = false;
                }
                else if (enemy.GetComponent<spiderJumpAtPlayer>() != null)
                {
                    enemy.gameObject.GetComponent<spiderJumpAtPlayer>().enabled = false;
                }
            }

            cross1.SetActive(true);

            // Start the cooldown
            isCooldown = true;
            cooldownTimer = cooldownDuration;


            
            Invoke("reEnableMovement", 2.5f);
            

        }

        // Update the cooldown timer
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

                cross1.SetActive(false);
            }
        }
    }
}
