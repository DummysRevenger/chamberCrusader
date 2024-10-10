using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerIsFrozenStore : MonoBehaviour
{
    public static playerIsFrozenStore S;

    public bool playerIsFrozen = false;

    public bool playerFrozenCooldown = false;

    private GameObject player;

    private playerMovement playerMoveScript;

    private SlipperyPlayerMovement playerMoveScript2;

    // Start is called before the first frame update
    void Start()
    {
        S = this;

        player = GameObject.FindGameObjectWithTag("Player");

        playerMoveScript = player.GetComponent<playerMovement>();

        playerMoveScript2 = player.GetComponent<SlipperyPlayerMovement>();
    }

    public void freeze()
    {
        if (!playerIsFrozen)
        {
            playerIsFrozen = true;
        }

        playerFrozenCooldown = false;

        stopUnFreeze();

    }



    public void unFreeze()
    {
        playerIsFrozen = false;

        playerFrozenCooldown = false;

        player.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);

        playerMoveScript2.enabled = true;

       // playerMoveScript.enabled = true;

    }


    public void stopUnFreeze()
    {
        CancelInvoke("unFreeze");
    }

    // Update is called once per frame
    void Update()
    {

        if (retributionMapStore.S.mapType == "ice")
        {

            

            if (playerIsFrozen && !playerFrozenCooldown)
            {

                Invoke("unFreeze", 1f);

                playerFrozenCooldown = true;



            }

            if (playerIsFrozen && !playerHasWarmBootsStore.S.hasWarmBoots)
            {
                hpStorePlayer.S.playerHealth -= 2f * Time.deltaTime;

                //playerMoveScript.enabled = false;

                playerMoveScript2.enabled = false;

                player.GetComponent<SpriteRenderer>().color = new Color(0f, 1f, 1f);
            }
        }


    }
}
