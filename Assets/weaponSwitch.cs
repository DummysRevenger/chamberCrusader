using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weaponSwitch : MonoBehaviour
{

    public static weaponSwitch S;

    public GameObject swordUI;

    public GameObject kitchenUI; // kitchen knife UI
    public GameObject AxeUI; // axe UI

    public GameObject shotGunUI;
    public GameObject katanaUI;
    public GameObject gunUI;

    public GameObject RPGUI;
    public GameObject KnifeUI;

    public GameObject scytheUI;
    public GameObject longSwordUI;
    public GameObject caneUI;
    public GameObject coinGunUI;
    public GameObject daggerUI;

    public GameObject prideSwordUI;

    public GameObject gluttonyForkUI;

    public GameObject ammoNum;

    // knight's weapons
    public GameObject sword;
    public GameObject gun;

    // ninja's weapons
    public GameObject katana;
    public GameObject shotgun;

    // soldier's weapons
    public GameObject rpg;
    public GameObject knife;

    // bunny's weapons
    public GameObject kitchenKnife;
    public GameObject Axe;

    //shopkeeper's weapons
    public GameObject coinGun;
    public GameObject cane;
    public GameObject longSword;
    public GameObject scythe;
    public GameObject dagger;

    //knight's sprites for weapon equips
    public Sprite knightShot;
    public Sprite knightSword;

    //ninja's sprites for weapons equips
    public Sprite ninjaShot;
    public Sprite ninjaSword;

    //soldier's sprites for weapon equips
    public Sprite soldierShot;
    public Sprite soldierSword;

    //wrath
    public GameObject clawUI;



    public GameObject player;

    // melee hurtboxes
    public GameObject swordHurt;
    public GameObject katanaHurt;
    public GameObject knifeHurt;
    public GameObject axeHurt;
    public GameObject caneHurt;
    public GameObject longSwordHurt;
    public GameObject scytheHurt;
    public GameObject daggerHurt;


    public int weaponEquipped = 1;

    public RawImage swordImage;
    public RawImage gunImage;
    public Text ammoText;

    private SpriteRenderer weaponSpriteRenderer;

    private GameObject childObject;

    public GameObject greedBowUI;


    // Start is called before the first frame update
    void Start()
    {
        S = this;

        player = GameObject.FindWithTag("Player");


        swordImage = swordUI.GetComponent<RawImage>();
        gunImage = gunUI.GetComponent<RawImage>();

        ammoText = ammoNum.GetComponent<Text>();

        swordImage.enabled = false;

        ammoText.enabled = false;



        if (playerSwitcher.S.playerType == "knight")
        {
            gunUI.SetActive(true);
            shotGunUI.SetActive(false);
            RPGUI.SetActive(false);
            kitchenUI.SetActive(false);
        }
        else if (playerSwitcher.S.playerType == "ninja")
        {
            gunUI.SetActive(false);
            shotGunUI.SetActive(true);
            RPGUI.SetActive(false);
            kitchenUI.SetActive(false);
        }
        else if (playerSwitcher.S.playerType == "soldier")
        {
            gunUI.SetActive(false);
            shotGunUI.SetActive(false);
            RPGUI.SetActive(true);
            kitchenUI.SetActive(false);
        }
        else if (playerSwitcher.S.playerType == "bunny")
        {
            gunUI.SetActive(false);
            shotGunUI.SetActive(false);
            RPGUI.SetActive(false);
            kitchenUI.SetActive(true);
        }
        else if (playerSwitcher.S.playerType == "shop")
        {
            gunUI.SetActive(false);
            shotGunUI.SetActive(false);
            RPGUI.SetActive(false);
            kitchenUI.SetActive(false);
            coinGunUI.SetActive(true);

        }
        else if (playerSwitcher.S.playerType == "pride")
        {
            prideSwordUI.SetActive(true);
        }
        else if (playerSwitcher.S.playerType == "gluttony")
        {
            gluttonyForkUI.SetActive(true);
        }
        else if (playerSwitcher.S.playerType == "wrath")
        {
            clawUI.SetActive(true);
        }
        else if (playerSwitcher.S.playerType == "greed")
        {
            greedBowUI.SetActive(true);
        }

    }

    IEnumerator equip()
    {

        if (weaponEquipped == 1)
        {
            ammoText.enabled = false;

            
            if (playerSwitcher.S.playerType == "knight")
            {

                swordUI.SetActive(true);

                player.GetComponent<SpriteRenderer>().sprite = knightSword;

                gunImage.enabled = false;
                swordImage.enabled = true;



                 childObject = sword.transform.Find("sword")?.gameObject;

                weaponSpriteRenderer = childObject.GetComponent<SpriteRenderer>();

                weaponSpriteRenderer.enabled = false;

                sword.SetActive(true);
                swordHurt.SetActive(true);

                yield return new WaitForSeconds(0.1f);

                weaponSpriteRenderer.enabled = true;

                gun.SetActive(false);
            }
            else if (playerSwitcher.S.playerType == "ninja")
            {

                player.GetComponent<SpriteRenderer>().sprite = ninjaSword;


                shotgun.SetActive(false);


                katana.SetActive(true);

                katanaUI.SetActive(true);

                shotGunUI.SetActive(false);

                gunUI.SetActive(false);

                 childObject = katana.transform.Find("katana")?.gameObject;

                weaponSpriteRenderer = childObject.GetComponent<SpriteRenderer>();

                weaponSpriteRenderer.enabled = false;


                katanaHurt.SetActive(true);

                yield return new WaitForSeconds(0.1f);

                weaponSpriteRenderer.enabled = true;

                
            }
            else if (playerSwitcher.S.playerType == "soldier")
            {
                player.GetComponent<SpriteRenderer>().sprite = soldierSword;


                rpg.SetActive(false);
                knife.SetActive(true);

                KnifeUI.SetActive(true);

                

                RPGUI.SetActive(false);


                 childObject = knife.transform.Find("knife")?.gameObject;

                weaponSpriteRenderer = childObject.GetComponent<SpriteRenderer>();

                weaponSpriteRenderer.enabled = false;


                knifeHurt.SetActive(true);

                yield return new WaitForSeconds(0.1f);

                weaponSpriteRenderer.enabled = true;


            }
            else if (playerSwitcher.S.playerType == "bunny")
            {

                


                kitchenKnife.SetActive(false);
                Axe.SetActive(true);

                AxeUI.SetActive(true);



                kitchenUI.SetActive(false);


                 childObject = Axe.transform.Find("axe")?.gameObject;

                weaponSpriteRenderer = childObject.GetComponent<SpriteRenderer>();

                weaponSpriteRenderer.enabled = false;


                axeHurt.SetActive(true);

                yield return new WaitForSeconds(0.1f);

                weaponSpriteRenderer.enabled = true;

            }
            else if (playerSwitcher.S.playerType == "shop")
            {

                dagger.SetActive(false);

                daggerHurt.SetActive(false);

                daggerUI.SetActive(false);

                coinGun.SetActive(true);
                coinGunUI.SetActive(true);

                switch (shopKeeperWeaponRandomiser.S.theWeapon)
                {
                    case "cane":

                        

                        cane.SetActive(false);
                        caneUI.SetActive(false);
                        caneHurt.SetActive(false);

                        

                        


                        break;
                    case "scythe":
                        scythe.SetActive(false);
                        scytheUI.SetActive(false);
                        scytheHurt.SetActive(false);

                        

                        break;
                    case "longSword":
                        longSword.SetActive(false);
                        longSwordUI.SetActive(false);
                        longSwordHurt.SetActive(false);

                        

                        
                        break;
                }


                GameObject offset = coinGun.transform.Find("gunoffset")?.gameObject;


                childObject = offset.transform.Find("gunGrip")?.gameObject;
                GameObject childObject2 = offset.transform.Find("gunBarrel")?.gameObject;


                weaponSpriteRenderer = childObject.GetComponent<SpriteRenderer>();

                SpriteRenderer weaponSpriteRenderer2 = childObject2.GetComponent<SpriteRenderer>();


                childObject = dagger.transform.Find("Dagger")?.gameObject;

                SpriteRenderer weaponSpriteRenderer3 = childObject.GetComponent<SpriteRenderer>();

                weaponSpriteRenderer3.enabled = false;


                yield return new WaitForSeconds(0.1f);

                weaponSpriteRenderer.enabled = true;

                weaponSpriteRenderer2.enabled = true;








            }

        }
        else if (weaponEquipped == 2)// melee weapon
        {
            
            


            


            if (playerSwitcher.S.playerType == "knight")
            {

                ammoText.enabled = true;

                player.GetComponent<SpriteRenderer>().sprite = knightShot;

                gunImage.enabled = true;
                swordImage.enabled = false;


                GameObject offset = gun.transform.Find("gunoffset")?.gameObject;


                 childObject = offset.transform.Find("gunGrip")?.gameObject;
                GameObject childObject2 = offset.transform.Find("gunBarrel")?.gameObject;


                SpriteRenderer SpriteRenderer = childObject.GetComponent<SpriteRenderer>();
                SpriteRenderer SpriteRenderer2 = childObject2.GetComponent<SpriteRenderer>();

                SpriteRenderer.enabled = false;
                SpriteRenderer2.enabled = false;

                sword.SetActive(false);
                swordHurt.GetComponent<BoxCollider2D>().enabled = false;

                swordHurt.SetActive(false);

                gun.SetActive(true);

                yield return new WaitForSeconds(0.1f);

                SpriteRenderer.enabled = true;
                SpriteRenderer2.enabled = true;
            }
            else if (playerSwitcher.S.playerType == "ninja")
            {
                ammoText.enabled = true;

                player.GetComponent<SpriteRenderer>().sprite = ninjaShot;


                gunImage.enabled = true;

                shotgun.SetActive(true);
                katana.SetActive(false);

                katanaUI.SetActive(false);
                shotGunUI.SetActive(true);

                GameObject offset = shotgun.transform.Find("gunoffset")?.gameObject;


                 childObject = offset.transform.Find("actualshotgun")?.gameObject;
                


                SpriteRenderer SpriteRenderer = childObject.GetComponent<SpriteRenderer>();
                

                SpriteRenderer.enabled = false;
                

                katana.SetActive(false);
                katanaHurt.GetComponent<BoxCollider2D>().enabled = false;

                katanaHurt.SetActive(false);

                shotgun.SetActive(true);

                yield return new WaitForSeconds(0.1f);

                SpriteRenderer.enabled = true;
                
            }
            else if (playerSwitcher.S.playerType == "soldier")
            {

                ammoText.enabled = true;

                player.GetComponent<SpriteRenderer>().sprite = soldierSword;


                rpg.SetActive(true);

                knife.SetActive(false);

                KnifeUI.SetActive(false);



                RPGUI.SetActive(true);

                GameObject offset = rpg.transform.Find("gunoffset")?.gameObject;

                 childObject = offset.transform.Find("actualshotgun")?.gameObject;

                

                SpriteRenderer SpriteRenderer = childObject.GetComponent<SpriteRenderer>();

                SpriteRenderer.enabled = false;


                knifeHurt.GetComponent<BoxCollider2D>().enabled = false;

                knifeHurt.SetActive(false);

                yield return new WaitForSeconds(0.1f);

                SpriteRenderer.enabled = true;
            }
            else if (playerSwitcher.S.playerType == "bunny")
            {
                


                kitchenKnife.SetActive(true);

                Axe.SetActive(false);

                AxeUI.SetActive(false);



                kitchenUI.SetActive(true);

                GameObject offset = kitchenKnife.transform.Find("gunoffset")?.gameObject;

                 childObject = offset.transform.Find("knifesprite")?.gameObject;



                SpriteRenderer SpriteRenderer = childObject.GetComponent<SpriteRenderer>();

                SpriteRenderer.enabled = false;


                axeHurt.GetComponent<BoxCollider2D>().enabled = false;

                axeHurt.SetActive(false);

                yield return new WaitForSeconds(0.1f);

                SpriteRenderer.enabled = true;
            }
            else if (playerSwitcher.S.playerType == "shop")
            {


                coinGun.SetActive(false);
                coinGunUI.SetActive(false);



                GameObject offset = coinGun.transform.Find("gunoffset")?.gameObject;


                childObject = offset.transform.Find("gunGrip")?.gameObject;
                GameObject childObject2 = offset.transform.Find("gunBarrel")?.gameObject;


                weaponSpriteRenderer = childObject.GetComponent<SpriteRenderer>();

                SpriteRenderer weaponSpriteRenderer2 = childObject2.GetComponent<SpriteRenderer>();


                weaponSpriteRenderer.enabled = false;
                weaponSpriteRenderer2.enabled = false;


                switch (shopKeeperWeaponRandomiser.S.theWeapon)
                {
                    case "cane":

                        playerMovementSpeedStore.S.speed += 0.7f;
                        cane.SetActive(true);
                        caneUI.SetActive(true);
                        caneHurt.SetActive(true);


                        childObject = cane.transform.Find("walkingCane")?.gameObject;

                        weaponSpriteRenderer = childObject.GetComponent<SpriteRenderer>();




                        break;
                    case "scythe":
                        scythe.SetActive(true);
                        scytheUI.SetActive(true);
                        scytheHurt.SetActive(true);

                        childObject = scythe.transform.Find("scythe")?.gameObject;

                        weaponSpriteRenderer = childObject.GetComponent<SpriteRenderer>();


                        break;
                    case "longSword":
                        longSword.SetActive(true);
                        longSwordUI.SetActive(true);
                        longSwordHurt.SetActive(true);

                        childObject = longSword.transform.Find("longSword")?.gameObject;

                        weaponSpriteRenderer = childObject.GetComponent<SpriteRenderer>();


                        break;
                }

                // implement spriterenderer disabling and enabling


                



                yield return new WaitForSeconds(0.1f);

                weaponSpriteRenderer.enabled = true;







            }

        }
        else if (weaponEquipped == 3)// other weapon
        {
            switch (shopKeeperWeaponRandomiser.S.theWeapon)
            {
                case "cane":


                    cane.SetActive(false);
                    caneUI.SetActive(false);
                    caneHurt.SetActive(false);


                    playerMovementSpeedStore.S.speed -= 0.7f;


                    childObject = cane.transform.Find("walkingCane")?.gameObject;

                    weaponSpriteRenderer = childObject.GetComponent<SpriteRenderer>();

                    weaponSpriteRenderer.enabled = false;
                    break;
                case "scythe":
                    scythe.SetActive(false);
                    scytheUI.SetActive(false);
                    scytheHurt.SetActive(false);

                    childObject = scythe.transform.Find("scythe")?.gameObject;

                    weaponSpriteRenderer = childObject.GetComponent<SpriteRenderer>();

                    weaponSpriteRenderer.enabled = false;
                    break;
                case "longSword":
                    longSword.SetActive(false);
                    longSwordUI.SetActive(false);
                    longSwordHurt.SetActive(false);

                    childObject = longSword.transform.Find("longSword")?.gameObject;

                    weaponSpriteRenderer = childObject.GetComponent<SpriteRenderer>();

                    weaponSpriteRenderer.enabled = false;
                    break;
            }

            dagger.SetActive(true);

            daggerHurt.SetActive(true);

            daggerUI.SetActive(true);

            


            childObject = dagger.transform.Find("Dagger")?.gameObject;

            weaponSpriteRenderer = childObject.GetComponent<SpriteRenderer>();


            yield return new WaitForSeconds(0.1f);

            weaponSpriteRenderer.enabled = true;
        }



    }
    

    // Update is called once per frame
    void Update()
    {

        player = GameObject.FindWithTag("Player");


        if ((Input.GetMouseButtonDown(1)) && !hpStorePlayer.S.gameOver)
        {
            switch(weaponEquipped)
            {
                case 1:
                    weaponEquipped = 2;
                    break;
                case 2:
                    if (playerSwitcher.S.playerType == "shop")
                    {
                        weaponEquipped = 3;
                    }
                    else
                    {
                        weaponEquipped = 1;
                    }
                    break;
                case 3:
                    weaponEquipped = 1;
                    break;
            }

            StartCoroutine(equip());
        }

        
    }
}
