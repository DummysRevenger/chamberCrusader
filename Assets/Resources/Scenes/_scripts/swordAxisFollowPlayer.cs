using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordAxisFollowPlayer : MonoBehaviour
{
    public GameObject knightObject;
    public GameObject ninjaObject;
    public GameObject soldierObject;
    public GameObject bunnyObject;


    // Update is called once per frame
    void FixedUpdate()
    {
        if (playerSwitcher.S.playerType == "knight")
        {
            transform.position = knightObject.transform.position;
        }
        else if (playerSwitcher.S.playerType == "ninja")
        {
            transform.position = ninjaObject.transform.position;
        }
        else if (playerSwitcher.S.playerType == "soldier")
        {
            transform.position = soldierObject.transform.position;
        }
        else if (playerSwitcher.S.playerType == "bunny")
        {
            transform.position = bunnyObject.transform.position;
        }
    }
}
