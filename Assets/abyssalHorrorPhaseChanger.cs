using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abyssalHorrorPhaseChanger : MonoBehaviour
{

    public static abyssalHorrorPhaseChanger S;

    private spawnTentacleAtPlayer tentacleScript;

    private hpStore healthScript;

    private spawnAbyssalLaser laserScript;

    public bool lastPhaseStarted = false;

    private bool penultimatePhaseStarted = false;

    private spawnViperFish viperSpawn;

    private abyssalHorrorShootProjectile shootScript;

    

    // Start is called before the first frame update
    void Start()
    {
        S = this;

        tentacleScript = GetComponent<spawnTentacleAtPlayer>();

        healthScript = GetComponent<hpStore>();

        laserScript = GetComponent<spawnAbyssalLaser>();

        viperSpawn = GetComponent<spawnViperFish>();

        shootScript = GetComponent<abyssalHorrorShootProjectile>();
    }

    // Update is called once per frame
    void Update()
    {

        if (healthScript.health <= 4000)
        {
            tentacleScript.spawnTime = 99999f;


            if (tentacleScript.theTentacle != null)
            {
                Destroy(tentacleScript.theTentacle);
            }

            laserScript.endLaserTime = 9999999f;

            

            lastPhaseStarted = true;

        }
        else if (healthScript.health <= 9000 && !lastPhaseStarted)
        {
            tentacleScript.spawnTime = 1.5f;

            laserScript.enabled = true;

            penultimatePhaseStarted = true;

            

            shootScript.CancelInvoke();

            Debug.Log("phase 3");

        }
        else if (healthScript.health <= 16000 && !lastPhaseStarted && !penultimatePhaseStarted) 
        {
            viperSpawn.enabled = true;

            shootScript.enabled = true;
        }
        
    }
}
