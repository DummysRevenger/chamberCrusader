using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSpawnBlackHole : MonoBehaviour
{

    public GameObject playerBlackHolePrefab;

    public GameObject playerBlackHoleObject;

    public GameObject cross2;

    private bool abilityRunning;

    private bool isCooldown;

    private float cooldownTimer = 0.0f;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void createBlackHole()
    {
        playerBlackHoleObject =  Instantiate(playerBlackHolePrefab, transform.position, transform.rotation);
    }

    void endAbility()
    {
        Destroy(playerBlackHoleObject);
        abilityRunning = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (!isCooldown && (Input.GetKeyDown(KeyCode.G) || Input.GetKeyDown(KeyCode.F)))
        {


            audioSource.clip = playerAudioStore.S.audioClips[3];
            audioSource.Play(); // Play the clip

            createBlackHole();

            cross2.SetActive(true);

            abilityRunning = true;

            
            cooldownTimer = 30f;
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
