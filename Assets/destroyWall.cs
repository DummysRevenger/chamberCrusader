using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyWall : MonoBehaviour
{

    public GameObject playerObject;

    
    public GameObject knight;
    public GameObject ninja;
    public GameObject soldier;
    public GameObject bunny;

    void Start()
    {


        

        knight = GameObject.Find("player");

        ninja = GameObject.Find("playerninja");

        soldier = GameObject.Find("playersoldier");

        bunny = GameObject.Find("playerbunny");
    }

    void FixedUpdate()
    {

        if (playerSwitcher.S.playerType == "knight")
        {
            playerObject = knight;
        }
        else if (playerSwitcher.S.playerType == "ninja")
        {
            playerObject = ninja;
        }
        else if (playerSwitcher.S.playerType == "soldier")
        {
            playerObject = soldier;
        }
        else if (playerSwitcher.S.playerType == "bunny")
        {
            playerObject = bunny;
        }

        if (playerObject.transform.position.y > 6.4f)
        {
            
            Destroy(gameObject);
        }
    }
}
