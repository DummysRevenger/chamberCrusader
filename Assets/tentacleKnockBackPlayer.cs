using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tentacleKnockBackPlayer : MonoBehaviour
{

    private bool attackOnCooldown = false;

    private GameObject player;

    private Rigidbody2D playerRb2d;

    private Vector3 direction;

    private Vector3 newPos;

    private playerMovement moveScript;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        moveScript = player.GetComponent<playerMovement>();

        playerRb2d = player.GetComponent<Rigidbody2D>();
    }




    private void goOffCooldown()
    {
        attackOnCooldown = false;
    }


    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            if (!attackOnCooldown)
            {
                Debug.Log("fhgufdhiugfd");

                knockPlayerBack();
            }
        }
    }



    void knockPlayerBack()
    {

        hpStorePlayer.S.playerHealth -= 100;

        moveScript.enabled = false;

            if (player.transform.position.x <= 0) // if the player is on the left side of the map
            {
                if (player.transform.position.y <= 0) // if the player is on the bottom side 
                {
                    direction = new Vector3(-3, -3, 0f);
                }
                else if (player.transform.position.y > 0) // if the player is on the top side 
                {
                    direction = new Vector3(-3, 3, 0f);
                }

            }
            else if (player.transform.position.x > 0) // if the player is on the right side of the map
            {
                if (player.transform.position.y <= 0) // if the player is on the bottom side 
                {
                    direction = new Vector3(3, -3, 0f);
                }
                else if (player.transform.position.y > 0) // if the player is on the top side 
                {
                    direction = new Vector3(3, 3, 0f);
                }
            }


            playerRb2d.AddForce(direction * 15555f, ForceMode2D.Impulse);

            attackOnCooldown = true;

            Invoke("goOffCooldown", 1f);

            Invoke("enableMovement", 0.3f);
        
    }

    void enableMovement()
    {
        moveScript.enabled = true;
    }



    // Update is called once per frame
    void Update()
    {

    }
}
