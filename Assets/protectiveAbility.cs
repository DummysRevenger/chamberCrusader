using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class protectiveAbility : MonoBehaviour
{
    private bool isCooldown = false;
    private float cooldownDuration = 5f; // Cooldown duration in seconds
    public float cooldownTimer = 0.0f;
    private AudioSource audioSource;
    public static protectiveAbility S;
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


        audioSource.clip = playerAudioStore.S.audioClips[2];



        if (!isCooldown && (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Y)))
        {

            cross2.SetActive(true);


            // play sound effect
            audioSource.Play();

            

            abilityRunning = true;

            

            // change player damage taken variable to 0.5f 
            // make damage taken variable in the player health store
            playerDamageTakenMultiplierStore.damageMultiplier = 0.25f;

            cooldownTimer = 20f;
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
            // change player sprite colour to blue
            playerSprite.color = new Color(0f, 0f, 255f);
        }


    }
}
