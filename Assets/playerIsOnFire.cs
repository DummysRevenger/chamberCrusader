using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerIsOnFire : MonoBehaviour
{
    public static playerIsOnFire S;

    public bool playerIsBurning = false;

    public bool playerBurningCooldown = false;

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        S = this;

        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void burn()
    {
        if (!playerIsBurning)
        {
            playerIsBurning = true;
        }

        stopUnburning();

        Invoke("unBurn", 3f);

        playerBurningCooldown = false;

    }

    public void unBurn()
    {
        playerIsBurning = false;

        playerBurningCooldown = false;

        player.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);


    }


    public void stopUnburning()
    {
        CancelInvoke("unBurn");
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsBurning && !playerBurningCooldown)
        {


            playerBurningCooldown = true;

        }

        if (playerIsBurning)
        {
            hpStorePlayer.S.playerHealth -= 20f * Time.deltaTime;

            player.GetComponent<SpriteRenderer>().color = new Color(0.8f, 0.5f, 0.1f);
        }



    }
}
