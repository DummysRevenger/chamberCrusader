using UnityEngine;

public class ninjaDash : MonoBehaviour
{
    public float dashDistance = 5f; // The distance the player will dash
    private float dashSpeed = 20f; // The speed at which the player will dash

    private Rigidbody2D rb;
    private Vector2 dashTarget;

    private Vector3 aimDirection;

    private bool isCooldown = false;
    private float cooldownDuration = 1f; // Cooldown duration in seconds
    public float cooldownTimer = 0.0f;

    public playerMovement movementScript;




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
                    Dash();
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
                }
            }
        }
    }

    private void Dash()
    {

        

        
        

            Vector3 mousePosition = Input.mousePosition;


            Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, transform.position.z - Camera.main.transform.position.z));

            aimDirection = (worldMousePosition - transform.position).normalized;

            // Set the dash target position
            dashTarget = transform.position + aimDirection * dashDistance;

            // Start dashing

            rb.velocity = aimDirection * dashSpeed;

            // Invoke StopDash function after dashing distance is covered
            Invoke("StopDash", dashDistance / dashSpeed);

            isCooldown = true;
            cooldownTimer = cooldownDuration;

        // disable movement script
        movementScript.enabled = false;




    }


    private void StopDash()
    {
        // Stop the player's movement
        rb.velocity = Vector2.zero;

        // enable movement script
        movementScript.enabled = true;
    }

}