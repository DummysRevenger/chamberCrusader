using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slothEnergyStore : MonoBehaviour
{

    public static slothEnergyStore S;

    public float totalEnergy = 0f;



    public swordRotation weaponScript;

    public slothTeleport tpScript;

    public slowDownEnemies slowScript;

    public GameObject slothCircleObject;

    public Animation spearAnimation;
    

    // Start is called before the first frame update
    void Start()
    {
        S = this;   
    }

    // Update is called once per frame
    void Update()
    {

        

        if (totalEnergy > 0 && totalEnergy <= 25)
        {
            playerMovementSpeedStore.S.speed = 2.5f;

            weaponScript.cooldown = 2f;

            totalEnergy -= 5 * Time.deltaTime;

            tpScript.teleportDistance = 5f;

            slowScript.slowFactor = 1.2f;

            // Set the new scale values
            slothCircleObject.transform.localScale = new Vector3(6f, 6f, 6f); // Doubles the size of the object

            spearAnimation["slothSpearThrust"].speed = 1f;


        }
        else if (totalEnergy > 25 && totalEnergy <= 50)
        {
            playerMovementSpeedStore.S.speed = 3.5f;

            weaponScript.cooldown = 1.5f;

            totalEnergy -= 15 * Time.deltaTime;

            tpScript.teleportDistance = 7f;

            slowScript.slowFactor = 1.5f;

            spearAnimation["slothSpearThrust"].speed = 2f;

            slothCircleObject.transform.localScale = new Vector3(7f, 7f, 7f); // Doubles the size of the object
        }
        else if (totalEnergy > 50 && totalEnergy <= 75)
        {
            playerMovementSpeedStore.S.speed = 5.5f;

            weaponScript.cooldown = 1f;

            spearAnimation["slothSpearThrust"].speed = 2.5f;

            totalEnergy -= 15 * Time.deltaTime;

            tpScript.teleportDistance = 9f;

            slowScript.slowFactor = 2f;

            slothCircleObject.transform.localScale = new Vector3(8f, 8f, 8f); // Doubles the size of the object
        }
        else if (totalEnergy > 75)
        {

            weaponScript.cooldown = 1;

            spearAnimation["slothSpearThrust"].speed = 3f;

            playerMovementSpeedStore.S.speed = 6f;

            totalEnergy -= 20 * Time.deltaTime;

            tpScript.teleportDistance = 11f;

            slowScript.slowFactor = 3f;

            if (totalEnergy > 100)
            {
                totalEnergy = 95;
            }


            slothCircleObject.transform.localScale = new Vector3(9f, 9f, 9f); // Doubles the size of the object
        }

        
    }
}
