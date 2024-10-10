using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerIsGildedStore : MonoBehaviour
{
    public static playerIsGildedStore S;

    public bool playerIsGilded = false;

    public bool playerGoldCooldown = false;

    public bool playerInGoldPuddle = false;

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        S = this;

        player = GameObject.FindGameObjectWithTag("Player");


    }

    public void gold()
    {
        if (!playerIsGilded)
        {

            playerDamageTakenMultiplierStore.damageMultiplier += 0.33f;

            playerIsGilded = true;
        }

        playerGoldCooldown = false;
    }

    public void unGold()
    {
        playerIsGilded = false;
        playerDamageTakenMultiplierStore.damageMultiplier -= 0.33f;
        playerGoldCooldown = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsGilded && !playerGoldCooldown)
        {
            playerGoldCooldown = true;

        }

        if (playerIsGilded)
        {
            player.GetComponent<SpriteRenderer>().color = new Color(0.5f, 0.5f, 0f);

            
        }
        


        
    }
}
