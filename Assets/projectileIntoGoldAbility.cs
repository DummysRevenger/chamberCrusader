using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileIntoGoldAbility : MonoBehaviour
{
    private bool isCooldown = false;
    private float cooldownDuration = 10f; // Cooldown duration in seconds
    private float abilityDuration = 5f; // Cooldown duration in seconds
    public float cooldownTimer = 0.0f;
    private AudioSource audioSource;
    public static projectileIntoGoldAbility S;
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


        abilityRunning = false;

        playerSprite.color = new Color(1f, 1f, 1f);

        playerDamageTakenMultiplierStore.damageMultiplier = 1f;




    }


    // Update is called once per frame
    void Update()
    {





        if (!isCooldown && (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Y)))
        {

            cross2.SetActive(true);


            // play sound effect

            audioSource.clip = playerAudioStore.S.audioClips[3];
            audioSource.Play(); // Play the clip

            abilityRunning = true;



            // change player damage taken variable to 0.5f 
            // make damage taken variable in the player health store
            

            cooldownTimer = 10f;
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

        if (abilityRunning)
        {
            // change player sprite colour to gold
            playerSprite.color = new Color(1f, 215f/255f, 0f);
        }


    }
}
