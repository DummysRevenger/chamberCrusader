using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gluttonyDefenseAbility : MonoBehaviour
{
    public bool abilityRunning;

    public bool isCooldown;

    private float cooldownDuration = 15f; // Cooldown duration in seconds

    public float cooldownTimer = 0.0f;

    public GameObject cross2;

    public static gluttonyDefenseAbility S;

    public bool fat;

    private AudioSource audioSource;
    

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    void widen()
    {
        // Get the current scale
        Vector3 currentScale = transform.localScale;

        // Modify the x-axis scale
        currentScale.x *= 2;

        // Apply the new scale
        transform.localScale = currentScale;

        fat = true;
    }

    void unwiden()
    {
        // Get the current scale
        Vector3 currentScale = transform.localScale;

        // Modify the x-axis scale
        currentScale.x /= 2;

        // Apply the new scale
        transform.localScale = currentScale;

        fat = false;
    }


    void endAbility()
    {
        //change damage multiplier back to 1

        //change player colour back to normal


        abilityRunning = false;

        unwiden();


        playerDamageTakenMultiplierStore.damageMultiplier = 1f;

        playerMovementSpeedStore.S.speed = 3f;

        


    }


    // Update is called once per frame
    void Update()
    {
        if (!isCooldown && (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Y)))
        {
            widen();

            abilityRunning = true;

            audioSource.clip = playerAudioStore.S.audioClips[2];
            audioSource.Play(); // Play the clip

            playerDamageTakenMultiplierStore.damageMultiplier = 0.3f;

            

            Invoke("endAbility", 7f);

            cross2.SetActive(false);
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
            playerMovementSpeedStore.S.speed = 1.75f;
        }

    }
}
