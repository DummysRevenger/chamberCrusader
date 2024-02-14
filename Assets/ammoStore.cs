using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammoStore : MonoBehaviour
{
    public static ammoStore S;

    public int playerAmmo = 20;

    // Start is called before the first frame update
    void Start()
    {
        S = this;

        if (playerSwitcher.S.playerType == "soldier")
        {
            playerAmmo = 10;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
