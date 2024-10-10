using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wrathExplosionAbility : MonoBehaviour
{

    public GameObject smallBoom;

    public GameObject bigBoom;

    private bool abilityRunning;

    public GameObject cross2;

    private bool isCooldown;

    
    public float cooldownTimer = 0.0f;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {



        if (!isCooldown && (Input.GetKeyDown(KeyCode.G) || Input.GetKeyDown(KeyCode.F)))
        {



            audioSource.clip = playerAudioStore.S.audioClips[3];
            audioSource.Play(); // Play the clip

            cross2.SetActive(true);



            if (wrathEnrageAbility.S.abilityRunning && hpStorePlayer.S.playerHealth > 500)
            {
                Instantiate(bigBoom, transform.position, transform.rotation);
                hpStorePlayer.S.playerHealth -= 200;
                cooldownTimer = 30f;
                isCooldown = true;
            }
            else if (!wrathEnrageAbility.S.abilityRunning && hpStorePlayer.S.playerHealth > 500)
            {
                hpStorePlayer.S.playerHealth -= 200;
                Instantiate(smallBoom, transform.position, transform.rotation);
                cooldownTimer = 15f;
                isCooldown = true;
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
