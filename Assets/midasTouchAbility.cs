using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class midasTouchAbility : MonoBehaviour
{

    public GameObject cross1;
    private float cooldownDuration3 = 15f; // Cooldown duration in seconds
    public float cooldownTimer = 0.0f;

    private bool abilityRunning;

    private bool isCooldown;

    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void endAbility()
    {
        abilityRunning = false;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("enemy") && abilityRunning) 
        {
            other.gameObject.GetComponent<hpStore>().health -= 300;

            other.gameObject.GetComponent<hpStore>().midasTouched = true;
        }
    }

    // Update is called once per frame
    void Update()
    {


        if (!isCooldown && (Input.GetKeyDown(KeyCode.G) || Input.GetKeyDown(KeyCode.F)))
        {

            audioSource.clip = playerAudioStore.S.audioClips[2];
            audioSource.Play(); // Play the clip

            cross1.SetActive(true);


            // Start the cooldown

            abilityRunning = true;


                isCooldown = true;

                Invoke("endAbility", 5f);

            


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
