using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinCoinBuffsApplier : MonoBehaviour
{

    public static spinCoinBuffsApplier S;

    // Start is called before the first frame update
    void Start()
    {
        S = this;

        Invoke("setBuffs", 1f);

        
    }

    public void setBuffs()
    {
        if (selectCharacter.mapSelected == "onion")
        {
            switch (coinsSpawnedCounter.S.tailsCount)
            {
                case 0:
                    nextRoomChecker.S.projectileDamage -= 30;
                    nextRoomChecker.S.meleeDamage *= 0.5f;
                    nextRoomChecker.S.enemyMovementSpeed -= 1f;
                    nextRoomChecker.S.enemyHealth -= 20;
                    hpStorePlayer.S.maxHealth *= 1.2f;
                    extraMeleeWeaponDamageStore.meleeDamageMultiplier += 0.2f;

                    Debug.Log("easy");

                    enemySpawnDifficultyStore.S.difficulty = "easy";

                    break;
                case 1:
                    nextRoomChecker.S.projectileDamage += 30;
                    nextRoomChecker.S.meleeDamage *= 2f;
                    nextRoomChecker.S.enemyMovementSpeed += 0.8f;
                    nextRoomChecker.S.enemyHealth += 40;
                    hpStorePlayer.S.maxHealth *= 0.8f;
                    extraMeleeWeaponDamageStore.meleeDamageMultiplier -= 0.2f;
                    playerMovementSpeedStore.S.speed *= 0.8f;


                    enemySpawnDifficultyStore.S.difficulty = "medium";

                    Debug.Log("medium");

                    // make spawns slightly more difficult
                    break;
                case 2:
                    nextRoomChecker.S.projectileDamage += 35;
                    nextRoomChecker.S.meleeDamage *= 2.2f;
                    nextRoomChecker.S.enemyMovementSpeed += 0.8f;
                    nextRoomChecker.S.enemyHealth += 50;
                    hpStorePlayer.S.maxHealth *= 0.7f;
                    extraMeleeWeaponDamageStore.meleeDamageMultiplier -= 0.3f;
                    playerMovementSpeedStore.S.speed *= 0.8f;

                    enemySpawnDifficultyStore.S.difficulty = "hard";

                    Debug.Log("hard");

                    // make spawns more difficult
                    break;
                case 3:
                    nextRoomChecker.S.projectileDamage += 40;
                    nextRoomChecker.S.meleeDamage *= 2.5f;
                    nextRoomChecker.S.enemyMovementSpeed += 1f;
                    nextRoomChecker.S.enemyHealth += 70;
                    hpStorePlayer.S.maxHealth *= 0.7f;
                    extraMeleeWeaponDamageStore.meleeDamageMultiplier -= 0.35f;
                    playerMovementSpeedStore.S.speed *= 0.8f;

                    enemySpawnDifficultyStore.S.difficulty = "insane";

                    Debug.Log("insane");

                    // make spawns insane
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
