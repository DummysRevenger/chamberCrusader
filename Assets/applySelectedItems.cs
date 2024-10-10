using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applySelectedItems : MonoBehaviour
{


    public GameObject grabberRangeObject;

    // Start is called before the first frame update
    void Start()
    {
        
        if (selectedItemsStore.magazineSelected)
        {
            // add extra ammo for the player

            switch(selectCharacter.characterSelected)
            {
                case "knight":
                    ammoStore.S.playerAmmo += 10;
                    break;
                case "ninja":
                    ammoStore.S.playerAmmo += 10;
                    break;

                case "soldier":
                    ammoStore.S.playerAmmo += 5;
                    break;

            }
        }

        if (selectedItemsStore.speedPotionSelected)
        {
            playerMovementSpeedStore.S.speed *= 1.20f;
        }

        
        if (selectedItemsStore.ragePotionSelected)
        {
            // add extra melee damage and extra melee attack speed

            extraMeleeWeaponDamageStore.meleeDamageMultiplier += 0.2f;

            // find the swordRotation scripts of the current character's melee weapon
            // access the cooldown variable and decrease it by 10%-20%

            GameObject sword;

            switch (selectCharacter.characterSelected)
            {
                case "knight":
                    sword = GameObject.Find("swordAxis");
                    sword.GetComponent<swordRotation>().cooldown /= 1.1f;
                    break;

                case "ninja":
                    sword = GameObject.Find("katanaAxis");
                    sword.GetComponent<swordRotation>().cooldown /= 1.1f;
                    break;

                case "soldier":
                    sword = GameObject.Find("knifeAxis");
                    sword.GetComponent<swordRotation>().cooldown /= 1.1f;
                    break;

                case "bunny":
                    sword = GameObject.Find("axeAxis");
                    sword.GetComponent<swordRotation>().cooldown /= 1.1f;
                    break;
            }

        }

        if (selectedItemsStore.foesBaneSelected)
        {
            // decrease enemy stats

            nextRoomChecker.S.enemyHealth /= 1.25f;
            nextRoomChecker.S.projectileDamage /= 1.25f;
            nextRoomChecker.S.meleeDamage /= 1.25f;
            nextRoomChecker.S.enemyMovementSpeed /= 1.5f;

        }


        // magnet
        if (selectedItemsStore.magnetSelected)
        {
            magnetiseGold.magnetFound = true;
        }

        // grabber

        if (selectedItemsStore.magnetSelected)
        {
            GameObject sword;

            grabberRangeObject.GetComponent<BoxCollider2D>().enabled = true;

            Vector3 currentScale = grabberRangeObject.transform.localScale;

            Vector3 newScaleGrabber = currentScale * 1.2f;

            grabberRangeObject.transform.localScale = newScaleGrabber;

            switch (selectCharacter.characterSelected)
            {
                case "knight":
                    sword = GameObject.Find("swordHurtBox");


                    currentScale = sword.transform.localScale;

                    Vector3 newScalesword = currentScale * 1.2f;

                    sword.transform.localScale = newScalesword;

                    break;

                case "ninja":
                    sword = GameObject.Find("katanaHurtBox");

                    currentScale = sword.transform.localScale;

                    Vector3 newScaleKatana = currentScale * 1.2f;

                    sword.transform.localScale = newScaleKatana;

                    break;

                case "soldier":
                    sword = GameObject.Find("knifeHurtBox");
                    currentScale = sword.transform.localScale;

                    Vector3 newScaleKnife = currentScale * 1.2f;

                    sword.transform.localScale = newScaleKnife;
                    break;

                case "bunny":
                    sword = GameObject.Find("axeHurtBox");

                    currentScale = sword.transform.localScale;

                    Vector3 newScaleAxe = currentScale * 1.2f;

                    sword.transform.localScale = newScaleAxe;
                    break;
            }

            
        }

        //grind stone
        if (selectedItemsStore.grindStoneSelected)
        {
            extraMeleeWeaponDamageStore.meleeDamageMultiplier += 0.5f;

            Debug.Log("damage greatly increased");
        }
        

        // vitality
        if (selectedItemsStore.vitalityPotionSelected)
        {
            hpStorePlayer.S.maxHealth += 150;

            Debug.Log("max health increased");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
