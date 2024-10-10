using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wishBoneBuffApplier : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {

        

        if (selectCharacter.mapSelected == "blood")
        {

            

            switch (boneWishOutcome.S.theOutcome)
            {
                case "bigWin":
                    nextRoomChecker.S.projectileDamage -= 30;
                    nextRoomChecker.S.meleeDamage *= 0.5f;
                    nextRoomChecker.S.enemyMovementSpeed -= 1f;
                    nextRoomChecker.S.enemyHealth -= 20;
                    hpStorePlayer.S.maxHealth *= 1.2f;
                    extraMeleeWeaponDamageStore.meleeDamageMultiplier += 0.2f;

                    Debug.Log("very easy");

                    enemySpawnDifficultyStore.S.difficulty = "easy";

                    break;
                case "win":

                    Debug.Log("easy");

                    enemySpawnDifficultyStore.S.difficulty = "easy";




                    break;
                case "tie":

                    Debug.Log("medium");

                    enemySpawnDifficultyStore.S.difficulty = "medium";

                    break;
                case "loss":
                    nextRoomChecker.S.projectileDamage += 20;
                    nextRoomChecker.S.meleeDamage *= 2f;
                    nextRoomChecker.S.enemyMovementSpeed += 0.5f;
                    nextRoomChecker.S.enemyHealth += 50;
                    hpStorePlayer.S.maxHealth *= 0.9f;
                    extraMeleeWeaponDamageStore.meleeDamageMultiplier -= 0.10f;
                    playerMovementSpeedStore.S.speed *= 0.9f;

                    Debug.Log("hard");

                    enemySpawnDifficultyStore.S.difficulty = "hard";




                    break;
                case "insane":
                    nextRoomChecker.S.projectileDamage += 40;
                    nextRoomChecker.S.meleeDamage *= 2.5f;
                    nextRoomChecker.S.enemyMovementSpeed += 1f;
                    nextRoomChecker.S.enemyHealth += 70;
                    hpStorePlayer.S.maxHealth *= 0.7f;
                    extraMeleeWeaponDamageStore.meleeDamageMultiplier -= 0.35f;
                    playerMovementSpeedStore.S.speed *= 0.8f;

                    Debug.Log("insane");

                    enemySpawnDifficultyStore.S.difficulty = "insane";
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
