using UnityEngine;

public class slothTeleport : MonoBehaviour
{
    public float teleportDistance = 5f; // The distance the player will dash

    private Rigidbody2D rb;
    private Vector2 dashTarget;

    private Vector3 aimDirection;

    private bool isCooldown = false;
    private float cooldownDuration = 5f; // Cooldown duration in seconds
    public float cooldownTimer = 0.0f;

    public playerMovement movementScript;

    private AudioSource audioSource;

    public GameObject crossUI;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

        audioSource = GetComponent<AudioSource>();

        if (!thrombusDisableAbilities.S.disableAbilities)
        {
            if (!isCooldown)
            {
                if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Y))
                {
                    tp();

                    audioSource.clip = playerAudioStore.S.audioClips[2];
                    audioSource.Play(); // Play the clip
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
                    crossUI.SetActive(false);
                }
            }
        }
    }

    private void tp()
    {



        crossUI.SetActive(true);


        Vector3 mousePosition = Input.mousePosition;


        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, transform.position.z - Camera.main.transform.position.z));

        aimDirection = (worldMousePosition - transform.position).normalized;

        // Set the tp target position
        dashTarget = transform.position + aimDirection * teleportDistance;

        //tp

        transform.position = dashTarget;

        // Invoke StopDash function after dashing distance is covered
        

        isCooldown = true;
        cooldownTimer = cooldownDuration;

        
        




    }


    

}