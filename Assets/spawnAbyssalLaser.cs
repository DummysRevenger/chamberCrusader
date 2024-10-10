using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnAbyssalLaser : MonoBehaviour
{


    public GameObject laserPrefab;

    public GameObject theLaser;

    public GameObject laserSpawnPoint;

    private GameObject player;

    private Vector3 gameObjectPosition;

    private float angle;

    private Quaternion targetRotation;

    private Quaternion octopusRotation;

    private Quaternion startRotation;


    private float elapsedTime = 0f;


    public float createLaserTime = 5f;

    public float endLaserTime = 7f;



    private AudioSource audioSource;



    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");

        createLaser();

        audioSource = GetComponent<AudioSource>();

    }

    public void createLaser()
    {
        theLaser = Instantiate(laserPrefab, laserSpawnPoint.transform.position, laserSpawnPoint.transform.rotation);


        audioSource.Play();

        startRotation = theLaser.transform.rotation;
        Invoke("endLaser", endLaserTime);
    }


    private void endLaser()
    {


        Destroy(theLaser);

        playerIsBlindStore.S.delayUnBlind();



        if (!abyssalHorrorPhaseChanger.S.lastPhaseStarted)
        {
            Invoke("createLaser", createLaserTime);
        }

        
    }

    


    private void LaserFaceThePlayer()
    {
        // Get the player's position
        Vector3 playerPosition = player.transform.position;

        // Get the game object's position
        gameObjectPosition = theLaser.transform.position;

        // Calculate the angle between the game object and the player
        angle = Mathf.Atan2(playerPosition.y - gameObjectPosition.y, playerPosition.x - gameObjectPosition.x) * Mathf.Rad2Deg;

        // Rotate the game object to face the player
        targetRotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    private void FaceThePlayer()
    {
        // Get the player's position
        Vector3 playerPosition = player.transform.position;

        // Get the game object's position
        gameObjectPosition = transform.position;

        // Calculate the angle between the game object and the player
        angle = Mathf.Atan2(playerPosition.y - gameObjectPosition.y, playerPosition.x - gameObjectPosition.x) * Mathf.Rad2Deg;

        // Rotate the game object to face the player
        octopusRotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }



    // Update is called once per frame
    void Update()
    {
        


        if (theLaser != null)
        {
            LaserFaceThePlayer();

            FaceThePlayer();
            theLaser.transform.rotation = Quaternion.RotateTowards(theLaser.transform.rotation, targetRotation, 60 * Time.deltaTime);


            Quaternion laserRotation = theLaser.transform.rotation;

            Quaternion adjustedRotation = laserRotation * Quaternion.Euler(0, 0, 90);

            transform.rotation = adjustedRotation;



        }
        else
        {
            Quaternion desiredRotation = Quaternion.Euler(0, 0, 0);
            transform.rotation = desiredRotation;
        }




        //theLaser.transform.rotation = targetRotation;

    }
}
