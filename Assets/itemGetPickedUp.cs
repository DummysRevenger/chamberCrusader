using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemGetPickedUp : MonoBehaviour
{

    private GameObject grabberRangeObject;

    private GameObject magnetAttractCoinsObject;

    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        grabberRangeObject = GameObject.Find("grabberIncreasedRange");

        audioSource = GetComponent<AudioSource>();
    }


    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {



            

            switch (gameObject.name)
            {

                case "warmBoots(Clone)":
                    if (coinCounterStore.roundCoinNumber >= 2500)
                    {
                        coinCounterStore.roundCoinNumber -= 2500;

                        consumableItemStore.S.itemEquipped = "warmBoots";

                        delayDisappear();
                    }
                    break;

                case "vitalityPotion(Clone)":

                    if (coinCounterStore.roundCoinNumber >= 2000)
                    {
                        coinCounterStore.roundCoinNumber -= 2000;
                        hpStorePlayer.S.maxHealth += 150;
                        Debug.Log("max health increased");
                        delayDisappear();
                    }
                    break;
                case "grindStone(Clone)":

                    if (coinCounterStore.roundCoinNumber >= 1500)
                    {
                        coinCounterStore.roundCoinNumber -= 1500;
                        extraMeleeWeaponDamageStore.meleeDamageMultiplier += 0.5f;
                        delayDisappear();

                    }
                    break;
                case "speedPotion(Clone)":
                    if (coinCounterStore.roundCoinNumber >= 1500)
                    {
                        coinCounterStore.roundCoinNumber -= 1500;
                        playerMovementSpeedStore.S.baseMovementSpeed *= 1.20f;
                        Debug.Log("movement speed increased");
                        delayDisappear();
                    }
                    break;
                case "ragePotion(Clone)":

                    if (coinCounterStore.roundCoinNumber >= 2000)
                    {

                        coinCounterStore.roundCoinNumber -= 2000;

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
                        delayDisappear();
                    }
                    break;

                case "boxOfAmmo(Clone)":
                    // increase ammo
                    if (coinCounterStore.roundCoinNumber >= 2500)
                    {

                        coinCounterStore.roundCoinNumber -= 2500;
                        ammoStore.S.playerAmmo += 100;
                        Debug.Log("ammo increased by 100");
                        delayDisappear();
                    }
                    else if (playerSwitcher.S.playerType != "knight"
                        && playerSwitcher.S.playerType != "ninja"
                        && playerSwitcher.S.playerType != "soldier")
                    {
                        extraMeleeWeaponDamageStore.meleeDamageMultiplier += 0.25f;

                        barrelCountStore.barrelCount += 0.25f;
                    }
                    break;
                case "beltOfAmmo(Clone)":
                    // increase ammo less

                    if (coinCounterStore.roundCoinNumber >= 1000)
                    {

                        coinCounterStore.roundCoinNumber -= 1000;
                        ammoStore.S.playerAmmo += 40;
                        Debug.Log("ammo increased by 40");
                        delayDisappear();
                    }
                    else if (playerSwitcher.S.playerType != "knight"
                        && playerSwitcher.S.playerType != "ninja"
                        && playerSwitcher.S.playerType != "soldier")
                    {
                        extraMeleeWeaponDamageStore.meleeDamageMultiplier += 0.1f;

                        barrelCountStore.barrelCount += 0.1f;
                    }
                    break;
                case "magOfAmmo(Clone)":
                    // increase ammo a bit less

                    if (coinCounterStore.roundCoinNumber >= 500)
                    {

                        coinCounterStore.roundCoinNumber -= 500;
                        ammoStore.S.playerAmmo += 20;
                        Debug.Log("ammo increased by 20");
                        delayDisappear();
                    }
                    else if (playerSwitcher.S.playerType != "knight" 
                        && playerSwitcher.S.playerType != "ninja"
                        && playerSwitcher.S.playerType != "soldier")
                    {
                        extraMeleeWeaponDamageStore.meleeDamageMultiplier += 0.05f;

                        barrelCountStore.barrelCount += 0.5f;
                    }
                        break;
                case "grabber(Clone)":

                    if (coinCounterStore.roundCoinNumber >= 1000)
                    {
                        coinCounterStore.roundCoinNumber -= 1000;

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
                        delayDisappear();

                    }
                    break;
                case "magnet(Clone)":

                    if (coinCounterStore.roundCoinNumber >= 200)
                    {

                        coinCounterStore.roundCoinNumber -= 200;
                        // enable the magnet attract object's script
                        magnetiseGold.magnetFound = true;
                        delayDisappear();
                    }
                    break;
                case "extraBarrel(Clone)":

                    if (coinCounterStore.roundCoinNumber >= 2000)
                    {
                        coinCounterStore.roundCoinNumber -= 2000;

                        barrelCountStore.barrelCount++;
                        delayDisappear();
                    }
                    break;
                case "hypnoticVortex(Clone)":
                    break;
                case "foesBane(Clone)":

                    if (coinCounterStore.roundCoinNumber >= 1500)
                    {

                        coinCounterStore.roundCoinNumber -= 1500;

                        nextRoomChecker.S.enemyHealth /= 1.25f;
                        nextRoomChecker.S.projectileDamage /= 1.25f;
                        nextRoomChecker.S.meleeDamage /= 1.25f;
                        nextRoomChecker.S.enemyMovementSpeed /= 1.5f;
                        delayDisappear();
                    }
                    break;
            }

            

        }
    }

    void delayDisappear()
    {
        audioSource.Play();

        transform.position = new Vector3(999f, 999f, 0f);

        Invoke("delete", 1f);
    }


    void delete()
    {
        Destroy(gameObject);
    }
    

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(coinCounterStore.roundCoinNumber);
    }
}
