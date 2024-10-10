using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soulEaterTrapPlayer : MonoBehaviour
{

    private float distanceThreshold = 3.5f;

    private GameObject player;

    private bool trapCooldown;

    private playerMovement moveScript;

    private GameObject movementKeysMashPrompt;

    private int quickTimeMashThreshold = 10;

    private bool playerIsTrapped = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");


        moveScript = player.GetComponent<playerMovement>();

        moveScript.enabled = true;


        
    }

    void OffCooldown()
    {
        trapCooldown = false;
    }

    void Update()
    {
        // Calculate the distance between the enemy and the player
        float distance = Vector3.Distance(transform.position, player.transform.position);

        // Check if the distance is less than the threshold
        if (distance < distanceThreshold && !trapCooldown)
        {
            trapCooldown = true;

            //moveScript.enabled = false;

            playerIsTrappedStore.S.isTrapped = true;

            playerIsTrapped = true;

            // Do something when the player is within the distance threshold
            Debug.Log("Player is within " + distanceThreshold + " units of the enemy!");
            // e.g. trigger an attack, stun the player, etc.

            

        }



        if (playerIsTrapped)
        {
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.U) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.J)
                || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.H) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.K))
            {
                quickTimeMashThreshold--;

                Debug.Log("getting out");
            }


            hpStorePlayer.S.playerHealth -= 100 * Time.deltaTime;


            playerIsTrappedStore.S.delayUntrap();

           if (quickTimeMashThreshold <= 0)
           {
                quickTimeMashThreshold = 10;

                playerIsTrapped = false;

                playerIsTrappedStore.S.unTrap();
           }
            
           
        }
        else
        {
            moveScript.enabled = true;
            Invoke("OffCooldown", 5f);
        }



    }
}
