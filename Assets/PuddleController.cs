using UnityEngine;

public class PuddleController : MonoBehaviour
{

    public playerMovement theMovementScript;

    private GameObject knight;
    private GameObject ninja;
    private GameObject soldier;
    private GameObject bunny;

    public GameObject player;

    private Vector3 playerDirection;

    public bool cooldownOver = true;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }


    void LateUpdate()
    {
        player = GameObject.FindGameObjectWithTag("Player");


        theMovementScript = player.GetComponent<playerMovement>();


    }

    void endCooldown()
    {
        cooldownOver = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


        // Check if the colliding object is the player
        if (collision.gameObject.CompareTag("Player") && cooldownOver)
        {

            

            Rigidbody2D playerRigidbody = collision.gameObject.GetComponent<Rigidbody2D>();


            if (playerRigidbody != null)
            {
                // Disable player movement control
                
                if (theMovementScript != null)
                {
                    theMovementScript.enabled = false;
                }




                if (theMovementScript.movement == new Vector3(0f, 0f, 0f))
                {
                    playerDirection = new Vector3(1f, 1f, 0f);

                    playerRigidbody.AddForce(playerDirection * 100000f, ForceMode2D.Impulse);
                }
                else
                {
                    // Calculate the player's movement direction
                    playerDirection = theMovementScript.movement.normalized;

                    // Apply force to the player in the direction they were moving
                    playerRigidbody.AddForce(playerDirection * 100000f, ForceMode2D.Impulse);
                }


                cooldownOver = false;
                Invoke("endCooldown", 0.5f);

            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // Check if the colliding object is the player
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody2D playerRigidbody = collision.gameObject.GetComponent<Rigidbody2D>();
            if (playerRigidbody != null)
            {
                // Enable player movement control

                playerRigidbody.velocity = Vector2.zero;


                if (theMovementScript != null)
                {
                    theMovementScript.enabled = true;
                }
            }
        }
    }
}