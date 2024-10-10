using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appearNearPlayer : MonoBehaviour
{

    private GameObject player;

    private bool attackOnCooldown;

    private Vector3 newPos;

    private viperfishDartAtPlayer attackScript;

    

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        attackScript = GetComponent<viperfishDartAtPlayer>();
    }


    void goOffCooldown()
    {
        attackOnCooldown = false;
    }


    void attackPlayer()
    {
        attackScript.delayAttack();
    }

    // Update is called once per frame
    void Update()
    {

        if (!attackOnCooldown)
        {
            if (player.transform.position.x <= 0) // if the player is on the left side of the map
            {
                if (player.transform.position.y <= 0) // if the player is on the bottom side 
                {
                    newPos = new Vector3(player.transform.position.x + 3, player.transform.position.y + 3, 0f);
                }
                else if (player.transform.position.y > 0) // if the player is on the top side 
                {
                    newPos = new Vector3(player.transform.position.x + 3, player.transform.position.y - 3, 0f);
                }

            }
            else if (player.transform.position.x > 0) // if the player is on the right side of the map
            {
                if (player.transform.position.y <= 0) // if the player is on the bottom side 
                {
                    newPos = new Vector3(player.transform.position.x - 3, player.transform.position.y + 3, 0f);
                }
                else if (player.transform.position.y > 0) // if the player is on the top side 
                {
                    newPos = new Vector3(player.transform.position.x - 3, player.transform.position.y - 3, 0f);
                }
            }




            attackPlayer();

            transform.position = newPos;

            attackOnCooldown = true;

            Invoke("goOffCooldown", 4f);
        }
    }
}
