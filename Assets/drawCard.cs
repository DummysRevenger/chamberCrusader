using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawCard : MonoBehaviour
{



    private GameObject tarotCardPrefab;

    private GameObject spawnedCard;

    public Sprite fool;

    public Sprite strength;

    public Sprite devil;

    public Sprite death;

    public Sprite chariot;

    public Sprite wheel;

    public GameObject rToRoll;



    public int randomNo;

    private SpriteRenderer renderer;

    private bool doneRolling = true;

    public GameObject diceNumberObject;


    public SpriteRenderer diceNumberRenderer;

    


    // Start is called before the first frame update
    void Start()
    {

        tarotCardPrefab = Resources.Load("Scenes/update12Resources/randomEvents/imagesandSpriteSheets/tarotCard") as GameObject;

        renderer = GetComponent<SpriteRenderer>();

    }


    void delayFightingStage()
    {
        fightingStageEnabler.S.enableFightingStage();

        nextRoomChecker.S.triggerSpawners();

        nextRoomChecker.S.rollDone = true;


        Invoke("applyBuffs", 1f);


        Destroy(spawnedCard);
    }

    void applyBuffs()
    {

        randomNo = Random.Range(0, 16);

        switch (randomNo)
        {
            case 0:
            case 6:
            case 7:


                nextRoomChecker.S.projectileDamage -= 40;
                nextRoomChecker.S.meleeDamage *= 0.25f;
                nextRoomChecker.S.enemyMovementSpeed -= 1.5f;
                nextRoomChecker.S.enemyHealth -= 40;
                hpStorePlayer.S.maxHealth *= 1.5f;
                extraMeleeWeaponDamageStore.meleeDamageMultiplier += 0.4f;
                break;
            case 1:
            case 15:


                extraMeleeWeaponDamageStore.meleeDamageMultiplier += 0.5f;
                hpStorePlayer.S.maxHealth *= 1.2f;
                break;
            case 2:
            case 14:

                hpStorePlayer.S.maxHealth *= 0.8f;
                extraMeleeWeaponDamageStore.meleeDamageMultiplier -= 0.2f;
                playerMovementSpeedStore.S.speed *= 0.8f;
                break;
            case 3:
                
                nextRoomChecker.S.projectileDamage += 20;
                nextRoomChecker.S.meleeDamage *= 1.7f;
                nextRoomChecker.S.enemyMovementSpeed += 0.5f;
                nextRoomChecker.S.enemyHealth += 25;
                hpStorePlayer.S.maxHealth *= 0.9f;
                extraMeleeWeaponDamageStore.meleeDamageMultiplier -= 0.2f;
                playerMovementSpeedStore.S.speed *= 0.8f;
                break;
            case 4:
            case 10:
            case 11:
            case 12:
            case 13:
                playerMovementSpeedStore.S.speed *= 0.8f;
                hpStorePlayer.S.maxHealth *= 1.1f;
                // chariot
                break;
            case 5:
            case 8:
            case 9:


                nextRoomChecker.S.enemyHealth /= 1.25f;
                nextRoomChecker.S.projectileDamage /= 1.25f;
                nextRoomChecker.S.meleeDamage /= 1.25f;
                nextRoomChecker.S.enemyMovementSpeed /= 1.5f;
                nextRoomChecker.S.enemyHealth /= 1.25f;
                nextRoomChecker.S.projectileDamage /= 1.25f;
                nextRoomChecker.S.meleeDamage /= 1.25f;
                nextRoomChecker.S.enemyMovementSpeed /= 1.5f;

                break;

        }
    }

    void stopRolling()
    {
        
        doneRolling = true;


        CancelInvoke();


        switch (randomNo)
        {
            case 0:
            case 6:
            case 7:
                spawnedCard.GetComponent<SpriteRenderer>().sprite = fool;

                
                break;
            case 1:
            case 15:
                spawnedCard.GetComponent<SpriteRenderer>().sprite = strength;

                
                break;
            case 2:
            case 14:
                spawnedCard.GetComponent<SpriteRenderer>().sprite = devil;
                
                break;
            case 3:
                spawnedCard.GetComponent<SpriteRenderer>().sprite = death;
                
                break;
            case 4:
            case 10:
            case 11:
            case 12:
            case 13:
                spawnedCard.GetComponent<SpriteRenderer>().sprite = chariot;
                // chariot
                break;
            case 5:
            case 8:
            case 9:
                spawnedCard.GetComponent<SpriteRenderer>().sprite = wheel;


                break;

        }




        Invoke("delayFightingStage", 3f);

    }


   


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && doneRolling)
        {

            doneRolling = false;

            spawnedCard = Instantiate(tarotCardPrefab, transform.position, transform.rotation);

            Invoke("stopRolling", 2f);

            
        }


       

        if (!doneRolling)
        {
            // Get the object's current position
            Vector3 currentPosition = spawnedCard.transform.position;

            // Calculate the direction towards the center
            Vector3 centerDirection = Vector3.zero - currentPosition;

            // Normalize the direction vector to get the unit vector
            centerDirection.Normalize();

            // Move the object towards the center
            spawnedCard.transform.position += centerDirection * 4* Time.deltaTime;
        }

    }
}
