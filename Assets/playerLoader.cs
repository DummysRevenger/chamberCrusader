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


    public GameObject shopKeep;
    public GameObject coinGun;
    public GameObject dagger;
    public GameObject randomWeapon;


    public GameObject pride;
    public GameObject prideSword;

    public GameObject sloth;
    public GameObject slothSpear;

    public GameObject gluttony;
    public GameObject gluttonyFork;

    public GameObject envy;
    public GameObject envyStaff;

    public GameObject lust;
    public GameObject lustGauntlets;
    public GameObject lustGauntletHurtBox;

    public GameObject greed;
    public GameObject greedBow;

    public GameObject wrath;
    public GameObject wrathClaws;





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
        else if (playerSwitcher.S.playerType == "shop")
        {
            shopKeep.SetActive(true);
            coinGun.SetActive(true);

            shopKeep.GetComponent<SpriteRenderer>().enabled = true;
            
        }
        else if (playerSwitcher.S.playerType == "pride")
        {
            pride.SetActive(true);
            prideSword.SetActive(true);
        }
        else if (playerSwitcher.S.playerType == "sloth")
        {
            sloth.SetActive(true);
            slothSpear.SetActive(true);
        }
        else if (playerSwitcher.S.playerType == "gluttony")
        {
            gluttony.SetActive(true);
            gluttonyFork.SetActive(true);

        }
        else if (playerSwitcher.S.playerType == "envy")
        {
            envy.SetActive(true);
            envyStaff.SetActive(true);
        }
        else if (playerSwitcher.S.playerType == "lust")
        {
            lust.SetActive(true);
            lustGauntlets.SetActive(true);
            lustGauntletHurtBox.SetActive(true);
        }
        else if (playerSwitcher.S.playerType == "greed")
        {
            greed.SetActive(true);
            greedBow.SetActive(true);
        }
        else if (playerSwitcher.S.playerType == "wrath")
        {
            wrath.SetActive(true);
            wrathClaws.SetActive(true);
        }
    }

   
}
