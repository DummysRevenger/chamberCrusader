using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerIsPoisonedStore : MonoBehaviour
{
    public static playerIsPoisonedStore S;

    public bool playerIsPoisoned = false;

    public bool playerPoisonedCooldown = false;

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        S = this;

        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void poison()
    {
        if (!playerIsPoisoned)
        {
            playerIsPoisoned = true;
        }

        playerPoisonedCooldown = false;

        stopUnpoisoning();
    }

    public void unPoison()
    {
        playerIsPoisoned = false;
        
        playerPoisonedCooldown = false;

        player.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);


    }


    public void stopUnpoisoning()
    {
        CancelInvoke("unPoison");
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsPoisoned && !playerPoisonedCooldown)
        {
            Invoke("unPoison", 2f);

            playerPoisonedCooldown = true;

        }
        

        if (playerIsPoisoned)
        {
            hpStorePlayer.S.playerHealth -= 10f * Time.deltaTime;

            player.GetComponent<SpriteRenderer>().color = new Color(0f, 0.5f, 0f);
        }



    }
}
