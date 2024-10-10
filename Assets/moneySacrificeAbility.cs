using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneySacrificeAbility : MonoBehaviour
{

    private bool isCooldown = false;
    private float cooldownDuration1 = 5f; // Cooldown duration in seconds
    private float cooldownDuration2 = 10f; // Cooldown duration in seconds
    private float cooldownDuration3 = 15f; // Cooldown duration in seconds
    public float cooldownTimer = 0.0f;
    public static moneySacrificeAbility S;


    public AudioSource audioSource;

    public GameObject cross1;


    // Start is called before the first frame update
    void Start()
    {
        S = this;

        audioSource = GetComponent<AudioSource>();
    }

    void endAbility()
    {
        gunRotation.S.greedCooldown = 2f;
    }

    // Update is called once per frame
    void Update()
    {

        if (!isCooldown && (Input.GetKeyDown(KeyCode.Y) || Input.GetKeyDown(KeyCode.E)))
        {




            audioSource.clip = playerAudioStore.S.audioClips[3];
            audioSource.Play(); // Play the clip

            if (coinCounterStore.roundCoinNumber > 250)
            {

                cross1.SetActive(true);


                // Start the cooldown
                isCooldown = true;
                

                if (coinCounterStore.roundCoinNumber >= 250 && coinCounterStore.roundCoinNumber < 1000)
                {
                    gunRotation.S.greedCooldown = 1.5f;
                    cooldownTimer = cooldownDuration1;

                    coinCounterStore.roundCoinNumber -= 250;
                }
                else if (coinCounterStore.roundCoinNumber >= 1000 && coinCounterStore.roundCoinNumber < 2000)
                {
                    gunRotation.S.greedCooldown = 1f;
                    cooldownTimer = cooldownDuration2;

                    coinCounterStore.roundCoinNumber -= 1000;
                }
                else if (coinCounterStore.roundCoinNumber >= 2000)
                {
                    gunRotation.S.greedCooldown = 0.5f;
                    cooldownTimer = cooldownDuration3;

                    coinCounterStore.roundCoinNumber -= 2000;
                }

                Invoke("endAbility", 5f);

            }


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
