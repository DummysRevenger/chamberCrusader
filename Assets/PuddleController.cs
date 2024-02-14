using UnityEngine;

public class PuddleController : MonoBehaviour
{

    public playerMovement theMovementScript;

    private GameObject knight;
    private GameObject ninja;
    private GameObject soldier;

    void Start()
    {

        


        
        
    }


    void LateUpdate()
    {
        if (selectCharacter.characterSelected == "knight")
        {
            knight = GameObject.Find("player");
            theMovementScript = knight.GetComponent<playerMovement>();


        }
        else if (selectCharacter.characterSelected == "ninja")
        {


            ninja = GameObject.Find("playerninja");


            theMovementScript = ninja.GetComponent<playerMovement>();
        }
        else if (selectCharacter.characterSelected == "soldier")
        {
            soldier = GameObject.Find("playersoldier");
            theMovementScript = soldier.GetComponent<playerMovement>();
        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the colliding object is the player
        if (collision.gameObject.CompareTag("Player"))
        {


            

            Rigidbody2D playerRigidbody = collision.gameObject.GetComponent<Rigidbody2D>();

            


            if (playerRigidbody != null)
            {
                // Disable player movement control
                
                if (theMovementScript != null)
                {
                    theMovementScript.enabled = false;
                    
                }


                


                // Calculate the player's movement direction
                Vector3 playerDirection = theMovementScript.movement.normalized;

                Debug.Log(playerDirection.magnitude);

                

                
                // Apply force to the player in the direction they were moving
                playerRigidbody.AddForce(playerDirection * 10f, ForceMode2D.Impulse);

                    


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