using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class D6Roll : MonoBehaviour
{

    private Animator theAnimator;

    public Sprite number1;

    public Sprite number2;

    public Sprite number3;

    public Sprite number4;

    public Sprite number5;

    public Sprite number6;

    private bool randomisationStarted;

    public GameObject rToRoll;


    private SpriteRenderer renderer;

    private bool doneRolling = true;

    public GameObject diceNumberObject;


    public SpriteRenderer diceNumberRenderer;


    private int randomNo;


    // Start is called before the first frame update
    void Start()
    {
        theAnimator = GetComponent<Animator>();

        theAnimator.enabled = false;

        renderer = GetComponent<SpriteRenderer>();

        diceNumberRenderer = diceNumberObject.GetComponent<SpriteRenderer>();

        
    }

    void setNumber()
    {
        


        


        if (selectCharacter.mapSelected == "dungeon")
        {
            switch (randomNo)
            {
                case 0:
                    nextRoomChecker.S.projectileDamage += 30;
                    nextRoomChecker.S.meleeDamage *= 2f;
                    nextRoomChecker.S.enemyMovementSpeed += 0.8f;
                    nextRoomChecker.S.enemyHealth += 40;
                    hpStorePlayer.S.maxHealth *= 0.8f;
                    extraMeleeWeaponDamageStore.meleeDamageMultiplier -= 0.2f;
                    playerMovementSpeedStore.S.speed *= 0.8f;
                    break;
                case 1:
                    nextRoomChecker.S.projectileDamage += 10;
                    nextRoomChecker.S.meleeDamage *= 1.5f;
                    nextRoomChecker.S.enemyMovementSpeed += 0.5f;
                    nextRoomChecker.S.enemyHealth += 20;
                    hpStorePlayer.S.maxHealth *= 0.9f;
                    extraMeleeWeaponDamageStore.meleeDamageMultiplier -= 0.1f;
                    playerMovementSpeedStore.S.speed *= 0.9f;
                    break;
                case 2:

                    break;
                case 3:
                    nextRoomChecker.S.projectileDamage -= 5;
                    nextRoomChecker.S.meleeDamage *= 0.9f;
                    nextRoomChecker.S.enemyMovementSpeed -= 0.25f;
                    nextRoomChecker.S.enemyHealth -= 5;
                    hpStorePlayer.S.maxHealth *= 1.05f;
                    extraMeleeWeaponDamageStore.meleeDamageMultiplier += 0.05f;
                    break;
                case 4:
                    nextRoomChecker.S.projectileDamage -= 10;
                    nextRoomChecker.S.meleeDamage *= 0.7f;
                    nextRoomChecker.S.enemyMovementSpeed -= 0.5f;
                    nextRoomChecker.S.enemyHealth -= 10;
                    hpStorePlayer.S.maxHealth *= 1.1f;
                    extraMeleeWeaponDamageStore.meleeDamageMultiplier += 0.1f;
                    break;
                case 5:
                    nextRoomChecker.S.projectileDamage -= 30;
                    nextRoomChecker.S.meleeDamage *= 0.5f;
                    nextRoomChecker.S.enemyMovementSpeed -= 1f;
                    nextRoomChecker.S.enemyHealth -= 20;
                    hpStorePlayer.S.maxHealth *= 1.2f;
                    extraMeleeWeaponDamageStore.meleeDamageMultiplier += 0.2f;
                    break;
            }
        }
        
    }

    
  

    void delayFightingStage()
    {
        fightingStageEnabler.S.enableFightingStage();

        
        
        Invoke("setNumber", 0.2f);

        // set rollDone to true


        if (selectCharacter.mapSelected == "retribution")
        {
            retributionRollApplier.S.applyBuffs();

        }

        rToRoll.GetComponent<Text>().text = "Press 'R' to roll again";

        retributionRollSum.S.rollList.Clear();

        retributionRollSum.S.theSum = 3;

        nextRoomChecker.S.rollDone = true;

        
        nextRoomChecker.S.triggerSpawners();

        




    }


    void stopRolling()
    {
        theAnimator.enabled = false;

        randomisationStarted = false;

        doneRolling = true;

        randomNo = Random.Range(0, 6);

        CancelInvoke();

        switch (randomNo)
        {
            case 0:
                diceNumberRenderer.sprite = number1;
                break;
            case 1:
                diceNumberRenderer.sprite = number2;
                break;
            case 2:
                diceNumberRenderer.sprite = number3;
                break;
            case 3:
                diceNumberRenderer.sprite = number4;
                break;
            case 4:
                diceNumberRenderer.sprite = number5;
                break;
            case 5:
                diceNumberRenderer.sprite = number6;
                break;
        }



        if (selectCharacter.mapSelected == "dungeon")
        {
            Invoke("delayFightingStage", 3f);
        }
        else
        {
            if (gameObject.name == "D61")
            {
                Invoke("delayFightingStage", 3f);
            }
        }


        if (gameObject.name == "D61")
        {
            Invoke("changeRetributionText", 0.5f);
        }


        if (selectCharacter.mapSelected == "retribution")
        {


            retributionRollSum.S.theSum += randomNo;


            switch (gameObject.name)
            {
                case "D63":
                    Invoke("addToList", 0.2f);
                    break;
                case "D62":
                    Invoke("addToList", 0.15f);
                    break;
                case "D61":
                    Invoke("addToList", 0.1f);
                    break;
            }

        }
    }

    void changeRetributionText()
    {
        if (retributionRollSum.S.rollList[0] == 3 && retributionRollSum.S.rollList[1] == 3 && retributionRollSum.S.rollList[2] == 3)
        {
            rToRoll.GetComponent<Text>().text = "A rather unlucky roll!";
        }
        else if ((retributionRollSum.S.rollList[0] == 4 && retributionRollSum.S.rollList[1] == 4 && retributionRollSum.S.rollList[2] == 4) || 
            (retributionRollSum.S.rollList[0] == 5 && retributionRollSum.S.rollList[1] == 5 && retributionRollSum.S.rollList[2] == 5))
        {
            
            rToRoll.GetComponent<Text>().text = "A rather lucky roll!";
        }
        else
        {
            Debug.Log(retributionRollSum.S.theSum);

            switch (retributionRollSum.S.theSum)
            {
                case 17:
                case 16:
                
                    rToRoll.GetComponent<Text>().text = "A very high roll!";

                    break;
                case 15:
                case 14:
                case 13:

                    rToRoll.GetComponent<Text>().text = "A high roll!";




                    break;
                case 11:
                case 12:
                case 10:
                case 9:

                    rToRoll.GetComponent<Text>().text = "A medium roll!";

                    break;
                case 8:
                case 6:
                case 5:
                case 4:
                case 3:
                case 2:
                case 1:

                    rToRoll.GetComponent<Text>().text = "A low roll...";

                    break;


                case 18:

                    rToRoll.GetComponent<Text>().text = "66666666666666666666666666666666666666666666666666666666666666";

                    break;

                case 7:

                    rToRoll.GetComponent<Text>().text = "lucky number 7!";
                    break;


            }
        }
    }

    void addToList()
    {
        retributionRollSum.S.rollList.Add(randomNo + 1);
    }


    void randomiseDiceNo()
    {
        randomisationStarted = true;

        int randomNo = Random.Range(0, 6);

        switch(randomNo)
        {
            case 0:
                diceNumberRenderer.sprite = number1;
                break;
            case 1:
                diceNumberRenderer.sprite = number2;
                break;
            case 2:
                diceNumberRenderer.sprite = number3;
                break;
            case 3:
                diceNumberRenderer.sprite = number4;
                break;
            case 4:
                diceNumberRenderer.sprite = number5;
                break;
            case 5:
                diceNumberRenderer.sprite = number6;
                break;
        }

        Invoke("randomiseDiceNo", 0.2f);
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && doneRolling)
        {

            doneRolling = false;

            theAnimator.enabled = true;

            Invoke("stopRolling", 3f);

            if (!gameObject.name.Contains("1") && !gameObject.name.Contains("2") && !gameObject.name.Contains("3"))
            {
                //rToRoll.SetActive(false);
            }
        }


        if (!doneRolling && !randomisationStarted)
        {
            randomiseDiceNo();
        }
    }
}
