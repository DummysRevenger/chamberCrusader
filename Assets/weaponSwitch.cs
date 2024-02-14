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

    //knight's sprites for weapon equips
    public Sprite knightShot;
    public Sprite knightSword;

    //ninja's sprites for weapons equips
    public Sprite ninjaShot;
    public Sprite ninjaSword;

    //soldier's sprites for weapon equips
    public Sprite soldierShot;
    public Sprite soldierSword;



    public GameObject player;

    // melee hurtboxes
    public GameObject swordHurt;
    public GameObject katanaHurt;
    public GameObject knifeHurt;
    public GameObject axeHurt;

    public bool gunEquipped = true;

    public RawImage swordImage;
    public RawImage gunImage;
    public Text ammoText;


    // Start is called before the first frame update
    void Start()
    {
        S = this;

        player = GameObject.FindWithTag("Player");


        swordImage = swordUI.GetComponent<RawImage>();
        gunImage = gunUI.GetComponent<RawImage>();

        ammoText = ammoNum.GetComponent<Text>();

        swordImage.enabled = false;


        


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

    }

    IEnumerator equip()
    {

        if (gunEquipped)
        {
            ammoText.enabled = false;
            gunEquipped = false;

            


            if (playerSwitcher.S.playerType == "knight")
            {

                player.GetComponent<SpriteRenderer>().sprite = knightSword;

                gunImage.enabled = false;
                swordImage.enabled = true;


                GameObject childObject = sword.transform.Find("sword")?.gameObject;

                SpriteRenderer spriteRenderer = childObject.GetComponent<SpriteRenderer>();

                spriteRenderer.enabled = false;

                sword.SetActive(true);
                swordHurt.SetActive(true);

                yield return new WaitForSeconds(0.1f);

                spriteRenderer.enabled = true;

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

                GameObject childObject = katana.transform.Find("katana")?.gameObject;

                SpriteRenderer spriteRenderer = childObject.GetComponent<SpriteRenderer>();

                spriteRenderer.enabled = false;

                
                katanaHurt.SetActive(true);

                yield return new WaitForSeconds(0.1f);

                spriteRenderer.enabled = true;

                
            }
            else if (playerSwitcher.S.playerType == "soldier")
            {
                player.GetComponent<SpriteRenderer>().sprite = soldierSword;


                rpg.SetActive(false);
                knife.SetActive(true);

                KnifeUI.SetActive(true);

                

                RPGUI.SetActive(false);


                GameObject childObject = knife.transform.Find("knife")?.gameObject;

                SpriteRenderer spriteRenderer = childObject.GetComponent<SpriteRenderer>();

                spriteRenderer.enabled = false;


               knifeHurt.SetActive(true);

                yield return new WaitForSeconds(0.1f);

                spriteRenderer.enabled = true;


            }
            else if (playerSwitcher.S.playerType == "bunny")
            {

                


                kitchenKnife.SetActive(false);
                Axe.SetActive(true);

                AxeUI.SetActive(true);



                kitchenUI.SetActive(false);


                GameObject childObject = Axe.transform.Find("axe")?.gameObject;

                SpriteRenderer spriteRenderer = childObject.GetComponent<SpriteRenderer>();

                spriteRenderer.enabled = false;


                axeHurt.SetActive(true);

                yield return new WaitForSeconds(0.1f);

                spriteRenderer.enabled = true;

            }

        }
        else
        {
            ammoText.enabled = true;
            gunEquipped = true;


            


            if (playerSwitcher.S.playerType == "knight")
            {

                player.GetComponent<SpriteRenderer>().sprite = knightShot;

                gunImage.enabled = true;
                swordImage.enabled = false;


                GameObject offset = gun.transform.Find("gunoffset")?.gameObject;


                GameObject childObject = offset.transform.Find("gunGrip")?.gameObject;
                GameObject childObject2 = offset.transform.Find("gunBarrel")?.gameObject;


                SpriteRenderer spriteRenderer = childObject.GetComponent<SpriteRenderer>();
                SpriteRenderer spriteRenderer2 = childObject2.GetComponent<SpriteRenderer>();

                spriteRenderer.enabled = false;
                spriteRenderer2.enabled = false;

                sword.SetActive(false);
                swordHurt.SetActive(false);

                gun.SetActive(true);

                yield return new WaitForSeconds(0.1f);

                spriteRenderer.enabled = true;
                spriteRenderer2.enabled = true;
            }
            else if (playerSwitcher.S.playerType == "ninja")
            {

                player.GetComponent<SpriteRenderer>().sprite = ninjaShot;


                gunImage.enabled = true;

                shotgun.SetActive(true);
                katana.SetActive(false);

                katanaUI.SetActive(false);
                shotGunUI.SetActive(true);

                GameObject offset = shotgun.transform.Find("gunoffset")?.gameObject;


                GameObject childObject = offset.transform.Find("actualshotgun")?.gameObject;
                


                SpriteRenderer spriteRenderer = childObject.GetComponent<SpriteRenderer>();
                

                spriteRenderer.enabled = false;
                

                katana.SetActive(false);
                katanaHurt.SetActive(false);

                shotgun.SetActive(true);

                yield return new WaitForSeconds(0.1f);

                spriteRenderer.enabled = true;
                
            }
            else if (playerSwitcher.S.playerType == "soldier")
            {
                player.GetComponent<SpriteRenderer>().sprite = soldierSword;


                rpg.SetActive(true);

                knife.SetActive(false);

                KnifeUI.SetActive(false);



                RPGUI.SetActive(true);

                GameObject offset = rpg.transform.Find("gunoffset")?.gameObject;

                GameObject childObject = offset.transform.Find("actualshotgun")?.gameObject;

                

                SpriteRenderer spriteRenderer = childObject.GetComponent<SpriteRenderer>();

                spriteRenderer.enabled = false;


                knifeHurt.SetActive(false);

                yield return new WaitForSeconds(0.1f);

                spriteRenderer.enabled = true;
            }
            else if (playerSwitcher.S.playerType == "bunny")
            {
                


                kitchenKnife.SetActive(true);

                Axe.SetActive(false);

                AxeUI.SetActive(false);



                kitchenUI.SetActive(true);

                GameObject offset = kitchenKnife.transform.Find("gunoffset")?.gameObject;

                GameObject childObject = offset.transform.Find("knifesprite")?.gameObject;



                SpriteRenderer spriteRenderer = childObject.GetComponent<SpriteRenderer>();

                spriteRenderer.enabled = false;


                axeHurt.SetActive(false);

                yield return new WaitForSeconds(0.1f);

                spriteRenderer.enabled = true;
            }

        }

        
    }
    

    // Update is called once per frame
    void Update()
    {

        if ((Input.GetMouseButtonDown(1)) && !hpStorePlayer.S.gameOver)
        {
            StartCoroutine(equip());
        }

        
    }
}
