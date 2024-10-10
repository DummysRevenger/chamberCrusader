using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOverSequence : MonoBehaviour
{

    public GameObject GO;
    public GameObject DGU;
    public GameObject FS;
    public GameObject FR;
    public GameObject RP;

    public GameObject ammoCount;
    public GameObject gunUI;
    public GameObject swordUI;

    public GameObject swordAxis;
    public GameObject swordHurtBox;
    public GameObject katanaAxis;
    public GameObject katanaHurtBox;
    public GameObject knifeAxis;
    public GameObject knifeHurtBox;
    public GameObject axeAxis;
    public GameObject axeHurtBox;

    public GameObject room;
    public GameObject score;

    public GameObject gun;
    public GameObject shotgun;
    public GameObject rpg;
    public GameObject thrownKnife;

    // pride
    public GameObject prideSwordAxis;
    public GameObject prideSwordHurtSpin;
    public GameObject prideSwordHurtSwing;
    public GameObject prideSwordHurtThrust;

    // lust
    public GameObject gauntletAxis;
    public GameObject gauntletHurtBox;
    public GameObject gauntletL;
    public GameObject gauntletR;

    // sloth
    public GameObject spearAxis;





    // envy
    public GameObject envyStaff;

    // gluttony
    public GameObject gluttonyFork;

    // greed
    public GameObject greedBow;

    // wrath
    public GameObject wrathClaw;
    public GameObject wrathHurtBox;



    public Color TextColor;


    public GameObject player;

    public GameObject knight;
    public GameObject ninja;
    public GameObject soldier;
    public GameObject bunny;


    public Sprite rip;

    public playerMovement scriptToDisable;
    public playerMovement scriptToDisable2;
    public playerMovement scriptToDisable3;
    public playerMovement scriptToDisable4;

    
    


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(startSequence());


        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    

    IEnumerator startSequence()
    {
        player.GetComponent<SpriteRenderer>().sprite = rip;
        


        statsStore.highScore = pointsStore.S.points;

        scriptToDisable.enabled = false;
        scriptToDisable2.enabled = false;
        scriptToDisable3.enabled = false;
        scriptToDisable4.enabled = false;


        if (selectCharacter.mapSelected == "blood" || (selectCharacter.mapSelected == "retribution" 
            && (retributionMapStore.S.mapType == "blood" || retributionMapStore.S.mapType == "fire")))
        {
            TextColor = new Color(0f, 0f, 1f);
        }
        else
        {
            TextColor = new Color(1f, 0f, 0f);
        }


        GO.GetComponent<Text>().color = TextColor;
        DGU.GetComponent<Text>().color = TextColor;
        FS.GetComponent<Text>().color = TextColor;
        FR.GetComponent<Text>().color = TextColor;
        RP.GetComponent<Text>().color = TextColor;
        


        ammoCount.SetActive(false);
        gunUI.SetActive(false);
        swordUI.SetActive(false);
        swordAxis.SetActive(false);
        swordHurtBox.SetActive(false);

        katanaAxis.SetActive(false);
        katanaHurtBox.SetActive(false);

        knifeAxis.SetActive(false);
        knifeHurtBox.SetActive(false);

        axeAxis.SetActive(false);
        axeHurtBox.SetActive(false);

        room.SetActive(false);
        score.SetActive(false);
        gun.SetActive(false);

        shotgun.SetActive(false);
        thrownKnife.SetActive(false);
        rpg.SetActive(false);

        prideSwordAxis.SetActive(false);
        prideSwordHurtSpin.SetActive(false);
    prideSwordHurtSwing.SetActive(false);
        prideSwordHurtThrust.SetActive(false);

        // lust
        gauntletAxis.SetActive(false);
        gauntletHurtBox.SetActive(false);
        gauntletL.SetActive(false);
        gauntletR.SetActive(false);

        // sloth
        spearAxis.SetActive(false);





        // envy
        envyStaff.SetActive(false);

        // gluttony
        gluttonyFork.SetActive(false);

        // greed
        greedBow.SetActive(false);

        // wrath
        wrathClaw.SetActive(false);
    wrathHurtBox.SetActive(false);



    yield return new WaitForSeconds(2f);
        GO.SetActive(true);
        yield return new WaitForSeconds(1f);
        DGU.SetActive(true);
        yield return new WaitForSeconds(1f);
        FS.SetActive(true);
        yield return new WaitForSeconds(1f);
        FR.SetActive(true);
        yield return new WaitForSeconds(1f);
        RP.SetActive(true);

    }
    
}
