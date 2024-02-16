using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLoader : MonoBehaviour
{
    public GameObject knight;
    public GameObject sword;
    public GameObject gun;
    public GameObject swordAxis;
    public GameObject swordHurt;


    public GameObject ninja;
    public GameObject shotgun;
    public GameObject katana;
    public GameObject katanaAxis;
    public GameObject katanaHurt;

    public GameObject soldier;
    public GameObject RPG;
    public GameObject knife;
    public GameObject knifeAxis;
    public GameObject knifeHurt;


    public GameObject bunny;
    public GameObject kitchenKnife;
    public GameObject axe;
    public GameObject axeAxis;
    public GameObject axeHurt;
    public GameObject ammoCounter;


    // Start is called before the first frame update
    void Start()
    {

        

        if (playerSwitcher.S.playerType == "knight")
        {
            knight.SetActive(true);
            gun.SetActive(true);

        }
        else if (playerSwitcher.S.playerType == "ninja")
        {
            ninja.SetActive(true);
            shotgun.SetActive(true);
        }
        else if (playerSwitcher.S.playerType == "soldier")
        {
            soldier.SetActive(true);
            RPG.SetActive(true);
        }
        else if (playerSwitcher.S.playerType == "bunny")
        {
            bunny.SetActive(true);
            kitchenKnife.SetActive(true);
            ammoCounter.SetActive(false);
            
        }

    }

   
}
