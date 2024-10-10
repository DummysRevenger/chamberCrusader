using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateShield : MonoBehaviour
{

    private bool isCooldown = false;
    private float cooldownDuration = 5f; // Cooldown duration in seconds
    public float cooldownTimer = 0.0f;
    public static activateShield S;

    private SpriteRenderer shieldRenderer;

    private BoxCollider2D shieldCollider;

    public GameObject cross1;





    // Start is called before the first frame update
    void Start()
    {
        S = this;
        shieldRenderer = GetComponent<SpriteRenderer>();
        shieldCollider = GetComponent<BoxCollider2D>();
        shieldRenderer.enabled = false;
        shieldCollider.enabled = false;

    }

    void makeShieldDisappear()
    {
        shieldRenderer.enabled = false;
        shieldCollider.enabled = false;
    }

    

    void Update()
    {
        if (!isCooldown && (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.G)))
        {
            shieldRenderer.enabled = true;
            shieldCollider.enabled = true;


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
