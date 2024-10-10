using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class retributionRollApplier : MonoBehaviour
{


    public static retributionRollApplier S;



    public void applyBuffs()
    {

        

        if (selectCharacter.mapSelected == "retribution")
        {
            if (retributionRollSum.S.rollList[0] == 3 && retributionRollSum.S.rollList[1] == 3 && retributionRollSum.S.rollList[2] == 3)
            {
                nextRoomChecker.S.projectileDamage += 20;
                nextRoomChecker.S.meleeDamage *= 0.5f;
                nextRoomChecker.S.enemyMovementSpeed += 0.5f;
                nextRoomChecker.S.enemyHealth += 20;

                if (nextRoomChecker.S.roomNumber != 0)
                {
                    hpStorePlayer.S.maxHealth *= 1.2f;
                }
                extraMeleeWeaponDamageStore.meleeDamageMultiplier -= 0.1f;
                

                Debug.Log("insane");

                enemySpawnDifficultyStore.S.difficulty = "insane";
            }
            else if (retributionRollSum.S.rollList[0] == 4 && retributionRollSum.S.rollList[1] == 4 && retributionRollSum.S.rollList[2] == 4)
            {
                nextRoomChecker.S.projectileDamage -= 20;
                nextRoomChecker.S.meleeDamage *= 0.5f;
                nextRoomChecker.S.enemyMovementSpeed -= 0.5f;
                nextRoomChecker.S.enemyHealth -= 20;
                if (nextRoomChecker.S.roomNumber != 0)
                {
                    hpStorePlayer.S.maxHealth *= 1.2f;
                }
                extraMeleeWeaponDamageStore.meleeDamageMultiplier += 0.2f;

                Debug.Log("very easy");

                enemySpawnDifficultyStore.S.difficulty = "easy";
            }
            else
            {



                switch (retributionRollSum.S.theSum)
                {
                    case 17:
                    case 7:
                    case 16:
                    
                        nextRoomChecker.S.projectileDamage -= 30;
                        nextRoomChecker.S.meleeDamage *= 0.5f;
                        nextRoomChecker.S.enemyMovementSpeed -= 1f;
                        nextRoomChecker.S.enemyHealth -= 20;
                        if (nextRoomChecker.S.roomNumber != 0)
                        {
                            hpStorePlayer.S.maxHealth *= 1.2f;
                        }
                        extraMeleeWeaponDamageStore.meleeDamageMultiplier += 0.2f;

                        

                        enemySpawnDifficultyStore.S.difficulty = "easy";

                        break;
                    case 15:
                    case 14:
                    case 13:
                    

                        nextRoomChecker.S.projectileDamage -= 10;
                        nextRoomChecker.S.meleeDamage *= 0.7f;
                        nextRoomChecker.S.enemyMovementSpeed -= 0.5f;
                        nextRoomChecker.S.enemyHealth -= 10;
                        if (nextRoomChecker.S.roomNumber != 0)
                        {
                            hpStorePlayer.S.maxHealth *= 1.1f;
                        }
                        extraMeleeWeaponDamageStore.meleeDamageMultiplier += 0.1f;

                        Debug.Log("medium");


                        enemySpawnDifficultyStore.S.difficulty = "medium";

                        break;
                    case 11:
                    case 12:
                    case 10:
                    case 9:

                        Debug.Log("medium");

                        enemySpawnDifficultyStore.S.difficulty = "medium";

                        break;
                    case 8:
                    case 6:
                    case 5:
                    case 4:
                    case 3:
                    case 2:
                    case 1:
                        nextRoomChecker.S.projectileDamage += 20;
                        nextRoomChecker.S.meleeDamage *= 0.5f;
                        nextRoomChecker.S.enemyMovementSpeed += 0.5f;
                        nextRoomChecker.S.enemyHealth += 20;
                        if (nextRoomChecker.S.roomNumber != 0)
                        {
                            hpStorePlayer.S.maxHealth *= 1.2f;
                        }
                        extraMeleeWeaponDamageStore.meleeDamageMultiplier -= 0.1f;


                        Debug.Log("insane");

                        enemySpawnDifficultyStore.S.difficulty = "insane";
                        break;


                    case 18:
                        nextRoomChecker.S.projectileDamage += 20;
                        nextRoomChecker.S.meleeDamage *= 0.5f;
                        nextRoomChecker.S.enemyMovementSpeed += 0.5f;
                        nextRoomChecker.S.enemyHealth += 20;
                        if (nextRoomChecker.S.roomNumber != 0)
                        {
                            hpStorePlayer.S.maxHealth *= 1.2f;
                        }
                        extraMeleeWeaponDamageStore.meleeDamageMultiplier -= 0.1f;


                        Debug.Log("insane");

                        enemySpawnDifficultyStore.S.difficulty = "insane";
                        break;


                }
            }
        }
    }




    // Start is called before the first frame update
    void Start()
    {
        S = this;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
