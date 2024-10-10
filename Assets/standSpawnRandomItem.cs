using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class standSpawnRandomItem : MonoBehaviour
{

    private Vector3 spawnOffset = new Vector3(0f, 1f, 0f);

    private GameObject foesBane;
    private GameObject grabber;
    private GameObject ragePotion;
    private GameObject vitalityPotion;
    private GameObject grindStone;
    private GameObject boxOfAmmo;
    private GameObject beltOfAmmo;
    private GameObject magOfAmmo;
    private GameObject extraBarrel;
    private GameObject magnet;
    private GameObject speedPotion;
    private GameObject warmBoots;

    // Start is called before the first frame update
    void Start()
    {
        


        // find the candies
        foesBane = Resources.Load("Scenes/update11Resources/shopkeeper/foesBane") as GameObject;
        grabber = Resources.Load("Scenes/update11Resources/shopkeeper/grabber") as GameObject;
        ragePotion = Resources.Load("Scenes/update11Resources/shopkeeper/ragePotion") as GameObject;
        vitalityPotion = Resources.Load("Scenes/update11Resources/shopkeeper/vitalityPotion") as GameObject;
        grindStone = Resources.Load("Scenes/update11Resources/shopkeeper/grindStone") as GameObject;
        boxOfAmmo = Resources.Load("Scenes/update11Resources/shopkeeper/boxOfAmmo") as GameObject;
        beltOfAmmo = Resources.Load("Scenes/update11Resources/shopkeeper/beltOfAmmo") as GameObject;
        magOfAmmo = Resources.Load("Scenes/update11Resources/shopkeeper/magOfAmmo") as GameObject;
        extraBarrel = Resources.Load("Scenes/update11Resources/shopkeeper/extraBarrel") as GameObject;
        magnet = Resources.Load("Scenes/update11Resources/shopkeeper/magnet") as GameObject;
        speedPotion = Resources.Load("Scenes/update11Resources/shopkeeper/speedPotion") as GameObject;

        warmBoots = Resources.Load("Scenes/update12Resources/newShopItems/warmBoots") as GameObject;


        int RandomNumber = Random.Range(0, 12);

        switch(RandomNumber)
        {
            case 0:
                Instantiate(foesBane, transform.position + spawnOffset, transform.rotation);
                break;
            case 1:
                Instantiate(grabber, transform.position + spawnOffset, transform.rotation);
                break;
            case 2:
                Instantiate(ragePotion, transform.position + spawnOffset, transform.rotation);
                break;
            case 3:
                Instantiate(speedPotion, transform.position + spawnOffset, transform.rotation);
                break;
            case 4:
                Instantiate(grindStone, transform.position + spawnOffset, transform.rotation);
                break;
            case 5:
                Instantiate(extraBarrel, transform.position + spawnOffset, transform.rotation);
                break;
            case 6:
                Instantiate(magnet, transform.position + spawnOffset, transform.rotation);
                break;
            case 7:
                Instantiate(vitalityPotion, transform.position + spawnOffset, transform.rotation);
                break;
            case 8:
                Instantiate(magOfAmmo, transform.position + spawnOffset, transform.rotation);
                break;
            case 9:
                Instantiate(beltOfAmmo, transform.position + spawnOffset, transform.rotation);
                break;
            case 10:
                Instantiate(boxOfAmmo, transform.position + spawnOffset, transform.rotation);
                break;
            case 11:
                Instantiate(warmBoots, transform.position + spawnOffset, transform.rotation);
                break;
        }

         

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
