using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class abilitySwitcher : MonoBehaviour
{

    public static abilitySwitcher S;

    // knight's abilities
    public GameObject shield;
    public GameObject shieldUI;
    public GameObject protectiveUI;
    public protectiveAbility knightProtect;
    public activateShield shieldScript;

    // ninja's abilities
    public GameObject dashUI;
    public GameObject ninjaSlashUI;
    public GameObject ninjaSlash;
    public slash slashScript;
    public ninjaDash dashScript;


    // soldier's abilities
    public GameObject bombUI;
    public GameObject rocketJumpUI;
    public rocketJump rocketJumpScript;
    public placeC4 soldierPlaceBomb;
    public detonateC4 soldierDetonateBomb;


    // bon's abilities
    public GameObject fireWorkUI;
    public GameObject rampageUI;
    public rampageAbility bunnyRampage;
    public launchFireWork fireWorkScript;


    //shop abilities
    public GameObject shopTorrentUI;
    public GameObject shopbullettogoldUI;
    public projectileIntoGoldAbility bulletToGold;
    public coinBlastAbility coinBlast;

    //greed abilities
    public GameObject moneysacrificeUI;
    public GameObject MIDASUI;
    public moneySacrificeAbility moneySac;
    public midasTouchAbility midas;

    //sloth abilities
    public GameObject TPUI;
    public GameObject SLEEPUI;
    public slothTeleport slothTP;
    public slowSlothAbility slowSloth;

    //lust abilities
    public GameObject LOVEUI;
    public GameObject FRENZYUI;
    public playerLustStunAbility lustStun;
    public playerLustFrenzyAbility lustFrenzy;

    //envy abilities
    public GameObject YOINKUI;
    public GameObject LASERUI;
    public envyStealAttackAbility envySteal;
    public jealousyBlast envyBlast;

    //pride abilities
    public GameObject PRIDEFULUI;
    public GameObject SWORDSPINUI;
    public prideGetPridefulAbility getPrideful;
    public prideSpinAttack prideSpinAbility;

    //gluttony abilities
    public GameObject FATUI;
    public GameObject BHUI;
    public gluttonyDefenseAbility fatAbility;
    public playerSpawnBlackHole bHScript;

    // WRATH ABILITIES
    public GameObject BOOMUI;
    public GameObject RAGEUI;
    public wrathExplosionAbility wrathExplode;
    public wrathEnrageAbility rageAbility;



    // Start is called before the first frame update
    void Start()
    {
        S = this;
    }

    


    // Update is called once per frame
    void Update()
    {

        if (playerSwitcher.S.playerType == "knight")
        {
            shield.SetActive(true);
            shieldUI.SetActive(true);
            protectiveUI.SetActive(true);
        }
        else if (playerSwitcher.S.playerType == "ninja")
        {

            dashUI.SetActive(true);
            ninjaSlashUI.SetActive(true);
            ninjaSlash.SetActive(true);

        }
        else if (playerSwitcher.S.playerType == "soldier")
        {
            bombUI.SetActive(true);
            rocketJumpUI.SetActive(true);
            

        }
        else if (playerSwitcher.S.playerType == "bunny")
        {
            fireWorkUI.SetActive(true);
            rampageUI.SetActive(true);
        }
        else if (playerSwitcher.S.playerType == "shop")
        {
            shopTorrentUI.SetActive(true);
            shopbullettogoldUI.SetActive(true);
        }
        else if (playerSwitcher.S.playerType == "envy")
        {
            YOINKUI.SetActive(true);
            LASERUI.SetActive(true);
        }
        else if (playerSwitcher.S.playerType == "greed")
        {
            MIDASUI.SetActive(true);
            moneysacrificeUI.SetActive(true);
        }
        else if (playerSwitcher.S.playerType == "lust")
        {
            LOVEUI.SetActive(true);
            FRENZYUI.SetActive(true);
        }
        else if (playerSwitcher.S.playerType == "gluttony")
        {
            FATUI.SetActive(true);
            BHUI.SetActive(true);
        }
        else if (playerSwitcher.S.playerType == "pride")
        {
            PRIDEFULUI.SetActive(true);
            SWORDSPINUI.SetActive(true);
        }
        else if (playerSwitcher.S.playerType == "wrath")
        {
            BOOMUI.SetActive(true);
            RAGEUI.SetActive(true);
        }
        else if (playerSwitcher.S.playerType == "sloth")
        {
            TPUI.SetActive(true);
            SLEEPUI.SetActive(true);
        }




        if (hpStorePlayer.S.playerHealth <= 0)
        {
            //switch off abilities after death




                // shield ability script
                shieldScript.enabled = false;
                // protective ability script
                knightProtect.enabled = false;
           

                // slash ability script
                slashScript.enabled = false;
                // dash ability script
                dashScript.enabled = false;

            
                // rocket jump ability script
                rocketJumpScript.enabled = false;
                // c4 ability
                
                soldierPlaceBomb.enabled = false;


            
                // rampage ability script 
                bunnyRampage.enabled = false;
                // firework ability script
                fireWorkScript.enabled = false;



       
        moneySac.enabled = false;
     midas.enabled = false;

    
    slothTP.enabled = false;
     slowSloth.enabled = false;;

   
    lustStun.enabled = false;
     lustFrenzy.enabled = false;

    
     envySteal.enabled = false;
    envyBlast.enabled = false;

   
    getPrideful.enabled = false;
    prideSpinAbility.enabled = false;

   
    fatAbility.enabled = false;
     bHScript.enabled = false;

    
    wrathExplode.enabled = false;
    rageAbility.enabled = false;


            coinBlast.enabled = false;
            bulletToGold.enabled = false;


}
    }


    
}
