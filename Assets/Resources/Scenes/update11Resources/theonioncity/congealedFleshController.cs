using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class congealedFleshController : MonoBehaviour
{

    private bool playerSlowedDown = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {


        // Check if the colliding object is the player
        if (collision.gameObject.CompareTag("Player"))
        {

            // slow the player down


            if (!playerSlowedDown)
            {
                playerSlowedDown = true;
                playerMovementSpeedStore.S.speed /= 2;
            }


        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // Check if the colliding object is the player
        if (collision.gameObject.CompareTag("Player"))
        {
            playerSlowedDown = false;

            playerMovementSpeedStore.S.speed *= 2;
        }
    }

}

        


