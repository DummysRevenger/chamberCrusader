using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextRoomChecker : MonoBehaviour
{
    public static nextRoomChecker S;
    public int roomNumber = 1;
    public GameObject topMiddleWall;
    public GameObject knightPlayer;
    public GameObject ninjaPlayer;
    public GameObject soldierPlayer;
    public GameObject bunnyPlayer;
    public GameObject shopPlayer;

    public GameObject playerBeginning;

    public GameObject ninjaUnlocked;

    public GameObject youFoundMeExe;

    public GameObject soldierUnlocked;

    public GameObject DUnlocked;
    public GameObject BZUnlocked;

    public bool rollDone;


    public GameObject player;

    public float enemyHealth = 45f;
    public float projectileDamage = 50f;
    public float meleeDamage = 1f;
    public float enemyMovementSpeed = 2f;

    public System.Random random = new System.Random();
    public int random1;
    public int random2;

    public int blueBunnyRandom;

    public GameObject blueBunny;

    public bool nextRoom;


    public GameObject bottomLeftSpawner;
    public GameObject bottomLeftSpawner2;
    public GameObject bottomRightSpawner;
    public GameObject bottomRightSpawner2;
    public GameObject topLeftSpawner;
    public GameObject topLeftSpawner2;
    public GameObject topRightSpawner;
    public GameObject topRightSpawner2;
    public GameObject middleLeftSpawner;
    public GameObject middleMiddleSpawner;
    public GameObject middleRightSpawner;

    public GameObject thirdSong; // desert
    public GameObject secondSong; // blood 
    public GameObject song; // dungeon
    public GameObject onionSong; //onion
    public GameObject caveSong; // limbo 
    public GameObject mudSong; // mud
    public GameObject goldSong; // gold
    public GameObject darkSong; // dark
    public GameObject stormSong; // lust storm
    public GameObject b4StormSong; // before the storm (plays in vestibule and swamp for now and first 3 levels of storm)
    public GameObject gottaGetOutSong; // plays in the fire zone for now


    public static bool Ninjaappeared = false;
    public static bool Soldierappeared = false;

    public static bool Desertappeared = false;
    public static bool Bloodappeared = false;

    private bool roomNumberIncremented = false;

    public bool spawn;


    void Awake()
    {
        roomNumber = 0;
    }

    void setFlag()
    {
        nextRoom = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        S = this;

        player = GameObject.FindGameObjectWithTag("Player");

        statsStore.roomsSeen++;


    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (roomNumber % 10 == 0 && !rollDone)
        {
            randomEventsTrigger.S.roll = true;
        }
        else if (roomNumber % 10 != 0)
        {
            rollDone = false;
        }


        if (selectCharacter.mapSelected == "blood")
        {
            secondSong.SetActive(true);
            song.SetActive(false);
        }
        else if (selectCharacter.mapSelected == "desert")
        {
            thirdSong.SetActive(true);
            secondSong.SetActive(false);
            song.SetActive(false);
        }
        else if (selectCharacter.mapSelected == "onion")
        {
            onionSong.SetActive(true);
            secondSong.SetActive(false);
            song.SetActive(false);
            thirdSong.SetActive(false);
        }
        else if (selectCharacter.mapSelected == "retribution")
        {
            switch (retributionMapStore.S.mapType)
            {
                case "vestibule": // 0 to 10
                    b4StormSong.SetActive(true);
                    break;
                case "limbo": // 11 to 20
                    caveSong.SetActive(true);
                    b4StormSong.SetActive(false);
                    break;
                case "lust": // 21 to 30
                    if (roomNumber < 24)
                    {
                        b4StormSong.SetActive(true);
                        caveSong.SetActive(false);
                    }
                    else
                    {
                        stormSong.SetActive(true);
                        b4StormSong.SetActive(false);
                    }
                    break;
                case "muddy":
                    mudSong.SetActive(true);
                    stormSong.SetActive(false);
                    break;
                case "greedy":
                    goldSong.SetActive(true);
                    mudSong.SetActive(false);
                    break;
                case "angry":
                    b4StormSong.SetActive(true);
                    goldSong.SetActive(false);
                    break;
                case "fire":
                    gottaGetOutSong.SetActive(true);
                    b4StormSong.SetActive(false);
                    break;
                case "violence":
                    secondSong.SetActive(true);
                    gottaGetOutSong.SetActive(false);
                    break;
                case "dark":
                    darkSong.SetActive(true);
                    secondSong.SetActive(false);
                    break;
                case "ice":
                    thirdSong.SetActive(true);
                    darkSong.SetActive(false);
                    break;
            }
        }




        player = GameObject.FindGameObjectWithTag("Player");



        if (roomNumber == 20 && enemiesInRoomChecker.S.enemiesInRoomNumber == 0)
        {
            /*if (selectCharacter.mapSelected == "dungeon" && !Bloodappeared)
            {
                room20checker.S.dungeon20Reached();

                Bloodappeared = true;

                BZUnlocked.SetActive(true);
                
            }
            else if (selectCharacter.mapSelected == "blood" && !Desertappeared)
            {
                room20checker.S.bloodZone20Reached();

                Desertappeared = true;

                DUnlocked.SetActive(true);
            }*/



        }

        if (roomNumber > 0 && enemiesInRoomChecker.S.enemiesInRoomNumber == 0 && !roomNumberIncremented)
        {


            statsStore.roomsComplete++;

            if (roomNumber == 10 && room10Skipper.skipped)
            {
                statsStore.roomsComplete--;
            }

            roomNumberIncremented = true;
        }

        if (roomNumber == 30 && enemiesInRoomChecker.S.enemiesInRoomNumber == 0)
        {


            /*if (selectCharacter.mapSelected == "dungeon" && !Ninjaappeared)
            {
                room30checker.S.dungeon30Reached();
                Ninjaappeared = true;
                ninjaUnlocked.SetActive(true);

            }
            else if (selectCharacter.mapSelected == "blood" && !Soldierappeared)
            {
                room30checker.S.bloodZone30Reached();
                Soldierappeared = true;
                soldierUnlocked.SetActive(true);

                
            }*/

        }


        if (roomNumber == 100)
        {
            youFoundMeExe.SetActive(true);

            enemiesInRoomChecker.S.enemiesInRoomNumber = 99999;
        }
        

        if (player != null)
        {

            if (player.transform.position.y > 7.9f && enemiesInRoomChecker.S.enemiesInRoomNumber == 0
                && tutorialDoneChecker.tutorialDone)
            {


                

                roomNumberIncremented = false;

                

                


                // destroy all walls

                /*
                GameObject[] walls = GameObject.FindGameObjectsWithTag("wall");

                foreach (GameObject wall in walls)
                {
                    Destroy(wall);
                }
                */


                nextRoom = true;



                statsStore.roomsSeen++;

                random1 = random.Next(0, 10);
                random2 = random.Next(0, 10);

                hpStorePlayer.S.playerHealth = hpStorePlayer.S.maxHealth;


                roomNumber++;

                blueBunnyRandom = random.Next(0, 70);

                if (blueBunnyRandom == 69)
                {
                    blueBunny.SetActive(true);
                }

                projectileDamage = 50 + roomNumber;

                meleeDamage = 0.05f * roomNumber;

                enemyMovementSpeed += 0.025f * roomNumber;

                if (enemyMovementSpeed >= 4.5f)
                {
                    enemyMovementSpeed = 4f;
                }

                enemyHealth += 5;



                if (selectCharacter.mapSelected == "blood")
                {
                    projectileDamage = 60 + roomNumber;

                    meleeDamage = 0.075f * roomNumber;

                    enemyMovementSpeed += 0.045f * roomNumber;

                    if (enemyMovementSpeed >= 4.5f)
                    {
                        enemyMovementSpeed = 4f;
                    }

                    enemyHealth += 8;
                }
                else if (selectCharacter.mapSelected == "desert")
                {
                    projectileDamage = 75 + roomNumber;

                    meleeDamage = 0.1f * roomNumber;

                    enemyMovementSpeed += 0.065f * roomNumber;

                    if (enemyMovementSpeed >= 4.5f)
                    {
                        enemyMovementSpeed = 4f;
                    }

                    enemyHealth += 12;
                }



                

                topMiddleWall.SetActive(true);


                Invoke("setFlag", 1f);

                if (roomNumber % 10 != 0)
                {
                    triggerSpawners();

                }

                

            }
        }
    }

    public void triggerSpawners()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        player.transform.position = playerBeginning.transform.position;

        if (roomNumber != 0)
        {
            //bottomLeftSpawner.GetComponent<enemySpawner>().spawnEnemy();

            //bottomLeftSpawner2.GetComponent<enemySpawner>().spawnEnemy();

            topLeftSpawner.GetComponent<enemySpawner>().spawnEnemy();

            topLeftSpawner2.GetComponent<enemySpawner>().spawnEnemy();

            topRightSpawner.GetComponent<enemySpawner>().spawnEnemy();

            topRightSpawner2.GetComponent<enemySpawner>().spawnEnemy();

            //bottomRightSpawner.GetComponent<enemySpawner>().spawnEnemy();

            //bottomRightSpawner2.GetComponent<enemySpawner>().spawnEnemy();

            middleLeftSpawner.GetComponent<blockSpawner>().spawnBlock();

            middleRightSpawner.GetComponent<blockSpawner>().spawnBlock();

            middleMiddleSpawner.GetComponent<blockSpawner>().spawnBlock();
        }
    }
}
