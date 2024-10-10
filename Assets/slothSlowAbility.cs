 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowSlothAbility : MonoBehaviour
{
    private bool isCooldown = false;
    private float cooldownDuration = 15f; // Cooldown duration in seconds
    public float cooldownTimer = 0.0f;
    private AudioSource audioSource;
    public static slowSlothAbility S;
    private SpriteRenderer playerSprite;
    public bool abilityRunning = false;


    public GameObject slothCircle;




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


        slothCircle.GetComponent<SpriteRenderer>().enabled = false;

        slothCircle.SetActive(false);
    }


    void slothCircleAppear()
    {
        slothCircle.GetComponent<SpriteRenderer>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {


        

        

        if (!isCooldown && (Input.GetKeyDown(KeyCode.G) || Input.GetKeyDown(KeyCode.F)))
        {

            cross2.SetActive(true);

            audioSource.clip = playerAudioStore.S.audioClips[3];
            audioSource.Play(); // Play the clip


            slothCircle.SetActive(true);


            Invoke("slothCircleAppear", 0.1f);

            // play sound effect
            audioSource.Play();



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
