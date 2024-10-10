using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLustFrenzyAbility : MonoBehaviour
{

    private bool abilityRunning;


    public float cooldownTimer = 0.0f;

    public GameObject cross1;


    public GameObject lustBombPrefab;

    private bool isCooldown;

    private float cooldownDuration = 15f; // Cooldown duration in seconds


    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void throwLustBomb()
    {
        
            Vector3 mousePosition = Input.mousePosition;
            Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, transform.position.z - Camera.main.transform.position.z));

            Vector3 aimDirection = (worldMousePosition - transform.position).normalized;


            GameObject bullet = Instantiate(lustBombPrefab, transform.position, Quaternion.identity);
            Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
            bulletRigidbody.velocity = 3f * aimDirection;
        
    }


    void disableAbility()
    {
        abilityRunning = false;
        throwLustBomb();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isCooldown && (Input.GetKeyDown(KeyCode.G) || Input.GetKeyDown(KeyCode.F)))
        {

            audioSource.clip = playerAudioStore.S.audioClips[2];
            audioSource.Play(); // Play the clip

            Invoke("disableAbility", 5f);
            abilityRunning = true;

            cross1.SetActive(true);
        }

        if (abilityRunning)
        {
            extraMeleeWeaponDamageStore.meleeDamageMultiplier = 1.5f;

            playerMovementSpeedStore.S.speed = 8f;


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

                cross1.SetActive(false);
            }
        }
    }
}
