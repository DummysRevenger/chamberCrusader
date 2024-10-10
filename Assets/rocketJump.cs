using UnityEngine;

public class rocketJump : MonoBehaviour
{
    public float dashDistance = 10f; // The distance the player will dash
    private float dashSpeed = 20f; // The speed at which the player will dash

    private Rigidbody2D rb;
    private Vector2 dashTarget;

    private Vector3 aimDirection;

    private bool isCooldown = false;
    private float cooldownDuration = 1f; // Cooldown duration in seconds
    public float cooldownTimer = 0.0f;

    public playerMovement movementScript;

    public GameObject explosion;

    public GameObject cross2;
    


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (!thrombusDisableAbilities.S.disableAbilities)
        {
            if (!isCooldown)
            {
                if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Y))
                {
                    jump();

                    cross2.SetActive(true);
                }
            }
            else
            {

                if (enemiesInRoomChecker.S.enemiesInRoomNumber > 0)
                {
                    cooldownTimer -= Time.deltaTime;
                }

                if (cooldownTimer <= 0.0f)
                {
                    isCooldown = false;
                    cross2.SetActive(false);
                }
            }
        }
    }

    private void jump()
    {


        cooldownTimer = 1.5f;

        hpStorePlayer.S.playerHealth -= 200;

        Vector3 mousePosition = Input.mousePosition;


        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, transform.position.z - Camera.main.transform.position.z));

        aimDirection = (worldMousePosition - transform.position).normalized;

        // Set the dash target position
        dashTarget = transform.position + aimDirection * dashDistance;

        // Start dashing

        rb.velocity = aimDirection * dashSpeed;

        // Invoke StopDash function after dashing distance is covered
        Invoke("StopRocketJump", dashDistance / dashSpeed);

        Instantiate(explosion, transform.position, transform.rotation);

        isCooldown = true;
        cooldownTimer = cooldownDuration;

        // disable movement script
        movementScript.enabled = false;



        playerDamageTakenMultiplierStore.damageMultiplier = 0f;



    }


    private void StopRocketJump()
    {
        // Stop the player's movement
        rb.velocity = Vector2.zero;

        playerDamageTakenMultiplierStore.damageMultiplier = 1f;

        // enable movement script
        movementScript.enabled = true;

        
    }

}