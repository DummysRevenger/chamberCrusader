using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHasWarmBootsStore : MonoBehaviour
{

    public static playerHasWarmBootsStore S;

    public bool hasWarmBoots = false;

    private GameObject player;

    private SlipperyPlayerMovement slipScript;

    private playerMovement moveScript;

    private int durability = 3;

    

    // Start is called before the first frame update
    void Start()
    {
        S = this;

        player = GameObject.FindGameObjectWithTag("Player");

        slipScript = player.GetComponent<SlipperyPlayerMovement>();

        moveScript = player.GetComponent<playerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (retributionMapStore.S.mapType == "ice")
        {
            if (hasWarmBoots)
            {
                slipScript.enabled = false;
                moveScript.enabled = true;
            }
            else
            {
                slipScript.enabled = true;
                moveScript.enabled = false;
            }
        }
        else
        {
            slipScript.enabled = false;
            moveScript.enabled = true;
        }
    }
}
