using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rampageAbility : MonoBehaviour
{
    private bool isCooldown = false;
    public float cooldownDuration = 5f; // Cooldown duration in seconds
    public float cooldownTimer = 0.0f;
    private AudioSource audioSource;
    public static rampageAbility S;

    private SpriteRenderer playerSprite;

    public bool abilityRunning = false;

    public GameObject rampageFlash1;

    public GameObject rampageFlash2;

    private Animator animator1;

    private Animator animator2;

    private changeColourOnHit changeColScript;

    public GameObject cross2;



    // Start is called before the first frame update
    void Start()
    {
        

        changeColScript = GetComponent<changeColourOnHit>();

        S = this;
        audioSource = GetComponent<AudioSource>();

        playerSprite = GetComponent<SpriteRenderer>();

        animator1 = rampageFlash1.GetComponent<Animator>();

        animator2 = rampageFlash2.GetComponent<Animator>();

    }

    void endAbility()
    {
        //change damage multiplier back to 1

        //change player colour back to normal

        changeColScript.enabled = true;

        abilityRunning = false;

        playerMovement.S.speed = 5f;

        playerSprite.color = new Color(1f, 1f, 1f);

        rampageFlash1.SetActive(false);

        rampageFlash2.SetActive(false);



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

                audioSource.Play();

                abilityRunning = true;

                cross2.SetActive(true);

                // change player damage taken variable to 0.5f 
                // make damage taken variable in the player health store


                rampageFlash1.SetActive(true);

                rampageFlash2.SetActive(true);

                animator1.Play("rampageflashanimation");

                animator2.Play("rampageflashanimation");



                playerMovement.S.speed = 7f;

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

            

            changeColScript.enabled = false;

            
        }


    }
}
