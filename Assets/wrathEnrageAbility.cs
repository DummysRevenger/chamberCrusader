using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wrathEnrageAbility : MonoBehaviour
{
    private bool isCooldown = false;
    public float cooldownDuration = 20f; // Cooldown duration in seconds
    public float cooldownTimer = 0.0f;
    

    public static wrathEnrageAbility S;

    private SpriteRenderer playerSprite;

    public bool abilityRunning = false;



    private AudioSource audioSource;

    public GameObject cross2;



    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();



        S = this;
        

        playerSprite = GetComponent<SpriteRenderer>();

        

    }

    void endAbility()
    {
        //change damage multiplier back to 1

        //change player colour back to normal

        abilityRunning = false;

        playerMovement.S.speed = 6f;

        

        


    }


    // Update is called once per frame
    void Update()
    {
        //audioSource.clip = playerAudioStore.S.audioClips[2];

        if (!thrombusDisableAbilities.S.disableAbilities)
        {
            if (!isCooldown && (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Y)))
            {


                audioSource.clip = playerAudioStore.S.audioClips[2];
                audioSource.Play(); // Play the clip


                abilityRunning = true;

                cross2.SetActive(true);

                // change player damage taken variable to 0.5f 
                // make damage taken variable in the player health store

                

                playerMovement.S.speed = 7f;

                extraMeleeWeaponDamageStore.meleeDamageMultiplier = 1.3333f;

                // increase damage

                cooldownTimer = 20f;
                isCooldown = true;

                Invoke("endAbility", 8f);
            }
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

        if (abilityRunning)
        {
            // change player sprite colour to red
            //playerSprite.color = new Color(0.5f, 0f, 0f);


            if (hpStorePlayer.S.playerHealth > 200)
            {
                hpStorePlayer.S.playerHealth -= 10 * Time.deltaTime;
            }




        }


    }
}
