using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerIsMuddedStore : MonoBehaviour
{
    public static playerIsMuddedStore S;

    public bool playerIsMudded = false;

    public bool playerMudCooldown = false;

    // Start is called before the first frame update
    void Start()
    {
        S = this;
    }

    public void Mud()
    {
        if (!playerIsMudded)
        {
            playerMovementSpeedStore.S.speed /= 2;
            playerIsMudded = true;
        }

        playerMudCooldown = false;

    }

    void unMud()
    {
        playerIsMudded = false;
        playerMovementSpeedStore.S.speed *= 2;
        playerMudCooldown = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsMudded && !playerMudCooldown)
        {
            Invoke("unMud", 1f);
            playerMudCooldown = true;

        }
    }
}
