using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerIsTrappedStore : MonoBehaviour
{

    public static playerIsTrappedStore S;

    public bool isTrapped;

    // Start is called before the first frame update
    void Start()
    {
        S = this;
    }

    void cancelUntrap()
    {
        CancelInvoke();
    }

    public void trap()
    {
        CancelInvoke();

        isTrapped = true;
    }

    public void delayUntrap()
    {
        Invoke("unTrap", 2f);
    }

    public void unTrap()
    {
        isTrapped = false;

        Debug.Log("please");

        switch (selectCharacter.characterSelected)
        {


            case "bunny":
                playerMovementSpeedStore.S.speed = 5f;
                break;
            case "knight":
            case "pride":
            case "envy":
                playerMovementSpeedStore.S.speed = 4f;
                break;
            case "sloth":
                playerMovementSpeedStore.S.speed = 2.5f;
                break;
            case "gluttony":
                playerMovementSpeedStore.S.speed = 3f;
                break;

            case "ninja":
            case "greed":
            case "lust":
                playerMovementSpeedStore.S.speed = 7f;
                break;

            case "soldier":
            case "wrath":
                playerMovementSpeedStore.S.speed = 6f;
                break;
            case "shop":
                playerMovementSpeedStore.S.speed = 5f;
                break;

        }
    }



    // Update is called once per frame
    void Update()
    {
        if (isTrapped)
        {
            playerMovementSpeedStore.S.speed = 0f;

            

            


            Invoke("unTrap", 0.33333f);
        }
    }
}
