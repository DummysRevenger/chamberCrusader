using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinBlastAbility : MonoBehaviour
{

    private bool isCooldown = false;
    private float cooldownDuration = 10f; // Cooldown duration in seconds
    public float cooldownTimer = 0.0f;
    public static coinBlastAbility S;

    private AudioSource audioSource;

    public GameObject cross1;

    public GameObject bigCoinPrefab;

    private float rotationAngle = 999f;







    // Start is called before the first frame update
    void Start()
    {
        S = this;

        audioSource = GetComponent<AudioSource>();
    }

    

    void Shoot(Vector3 direction)
    {
        GameObject bullet4 = Instantiate(bigCoinPrefab, transform.position, Quaternion.identity);
        Rigidbody2D bulletRigidbody4 = bullet4.GetComponent<Rigidbody2D>();

        

        bulletRigidbody4.velocity = 10f * direction.normalized;
    }

    void Shoot8()
    {
        Shoot(Vector3.up);
        Shoot(Vector3.down);
        Shoot(Vector3.left);
        Shoot(Vector3.right);
        Shoot(Vector3.up + Vector3.left);
        Shoot(Vector3.up + Vector3.right);
        Shoot(Vector3.down + Vector3.left);
        Shoot(Vector3.down + Vector3.right);
    }

    void Update()
    {

        GetComponent<SpriteRenderer>().enabled = true;

        if (!isCooldown && (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.G)))
        {

            audioSource.clip = playerAudioStore.S.audioClips[2];
            audioSource.Play(); // Play the clip

            Shoot8();
            Invoke("Shoot8", 0.5f);
            Invoke("Shoot8", 1f);
            Invoke("Shoot8", 1.5f);
            Invoke("Shoot8", 2.5f);
            Invoke("Shoot8", 2.25f);


            // F key has been pressed down and cooldown is not active
            // Perform your desired actions here



            Invoke("makeShieldDisappear", 0.75f);

            cross1.SetActive(true);

            // Start the cooldown
            isCooldown = true;
            cooldownTimer = cooldownDuration;
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
