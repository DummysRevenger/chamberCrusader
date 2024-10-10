using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knockBackPlayer : MonoBehaviour
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


    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            if (!attackOnCooldown)
            {

                knockPlayerBack();
            }
        }
    }



    void knockPlayerBack()
    {



        if (player.transform.position.x <= transform.position.x) // if the player is to the left of the object
        {
            if (player.transform.position.y <= 0) // if the player below
            {
                direction = new Vector3(-3, -3, 0f);
            }
            else if (player.transform.position.y > 0) // if the player above
            {
                direction = new Vector3(-3, 3, 0f);
            }

        }
        else if (player.transform.position.x > transform.position.x) // if the player is to the right of the object
        {
            if (player.transform.position.y <= transform.position.y) // if the player below
            {
                direction = new Vector3(3, -3, 0f);
            }
            else if (player.transform.position.y > transform.position.y) // if the player above
            {
                direction = new Vector3(3, 3, 0f);
            }
        }


        playerRb2d.AddForce(direction * 45555f, ForceMode2D.Impulse);

        attackOnCooldown = true;

        Invoke("goOffCooldown", 1f);

        

    }

    



    // Update is called once per frame
    void Update()
    {

    }
}
