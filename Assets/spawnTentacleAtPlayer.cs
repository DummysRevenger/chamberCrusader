using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnTentacleAtPlayer : MonoBehaviour
{

    private GameObject player;

    private Vector3 playerPos;

    private Vector3 posToMove;


    public GameObject warningPrefab;

    public GameObject theWarning;


    private bool isInvoking = false;

    private Vector3 positionToTeleport;

    public GameObject tentaclePrefab;


    public GameObject theTentacle;

    public float spawnTime;


    

    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");


        spawnTime = 1f;

        Invoke("warn", spawnTime);
    }

    void spawn()
    {
        if (theWarning != null)
        {
            Destroy(theWarning);
        }

        Quaternion desiredRotation = Quaternion.Euler(0, 0, 0);

        theTentacle = Instantiate(tentaclePrefab, positionToTeleport, desiredRotation);

        Invoke("warn", spawnTime * 2);

        Invoke("destroyTentacle", spawnTime);
    }


    void destroyTentacle()
    {
        Destroy(theTentacle);
    }

    void warn()
    {



        positionToTeleport = player.transform.position;

        Quaternion desiredRotation = Quaternion.Euler(0, 0, 0);

        theWarning = Instantiate(warningPrefab, positionToTeleport, desiredRotation);

        Invoke("spawn", 0.5f);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
