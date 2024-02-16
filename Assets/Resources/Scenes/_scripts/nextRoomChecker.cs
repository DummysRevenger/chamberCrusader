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

    public GameObject ninjaUnlocked;
    public GameObject soldierUnlocked;

    public GameObject DUnlocked;
    public GameObject BZUnlocked;


    public GameObject player;

    public float enemyHealth = 50f;
    public int projectileDamage = 50;
    public float meleeDamage = 1f;
    public float enemyMovementSpeed = 2f;

    public System.Random random = new System.Random();
    public int random1;
    public int random2;

    public GameObject bottomLeftSpawner;
    public GameObject bottomRightSpawner;
    public GameObject topLeftSpawner;
    public GameObject topRightSpawner;
    public GameObject middleLeftSpawner;
    public GameObject middleMiddleSpawner;
    public GameObject middleRightSpawner;

    public GameObject thirdSong;
    public GameObject secondSong;
    public GameObject song;


    public static bool Ninjaappeared = false;
    public static bool Soldierappeared = false;

    public static bool Desertappeared = false;
    public static bool Bloodappeared = false;



    // Start is called before the first frame update
    void Start()
    {
        S = this;

        

        roomNumber = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (selectCharacter.characterSelected == "knight")
        {
            player = knightPlayer;
        }
        else if (selectCharacter.characterSelected == "ninja")
        {
            player = ninjaPlayer;
        }
        else if (selectCharacter.characterSelected == "soldier")
        {
            player = soldierPlayer;
        }
        else if (selectCharacter.characterSelected == "bunny")
        {
            player = bunnyPlayer;
        }

        if (roomNumber == 20 && enemiesInRoomChecker.S.enemiesInRoomNumber == 0)
        {
            if (selectCharacter.mapSelected == "dungeon" && !Bloodappeared)
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
            }
            


        }

        if (roomNumber == 30 && enemiesInRoomChecker.S.enemiesInRoomNumber == 0)
        {


            if (selectCharacter.mapSelected == "dungeon" && !Ninjaappeared)
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

                
            }

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
        

        if (player.transform.position.y > 8f)
        {

            random1 = random.Next(0, 10);
            random2 = random.Next(0, 10);

            hpStorePlayer.S.playerHealth = hpStorePlayer.S.maxHealth;

            
            roomNumber++;


            

            projectileDamage = 50 + roomNumber;

            meleeDamage = 0.05f * roomNumber;

            enemyMovementSpeed += 0.025f * roomNumber;

            if (enemyMovementSpeed >= 4.5f)
            {
                enemyMovementSpeed = 4f;
            }

            enemyHealth += 10;



            if (selectCharacter.mapSelected == "blood")
            {
                projectileDamage = 60 + roomNumber;

                meleeDamage = 0.075f * roomNumber;

                enemyMovementSpeed += 0.045f * roomNumber;

                if (enemyMovementSpeed >= 4.5f)
                {
                    enemyMovementSpeed = 4f;
                }

                enemyHealth += 15;
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

                enemyHealth += 20;
            }



            playerMovement.S.transform.position = new Vector3(0f, -3f, 0f);
            topMiddleWall.SetActive(true);

            bottomLeftSpawner.GetComponent<enemySpawner>().spawnEnemy();
            middleLeftSpawner.GetComponent<enemySpawner>().spawnEnemy();
            topLeftSpawner.GetComponent<enemySpawner>().spawnEnemy();

            topRightSpawner.GetComponent<enemySpawner>().spawnEnemy();
            bottomRightSpawner.GetComponent<enemySpawner>().spawnEnemy();
            middleRightSpawner.GetComponent<enemySpawner>().spawnEnemy();

            
            


            
            middleLeftSpawner.GetComponent<blockSpawner>().spawnBlock();
            

            
            
            middleRightSpawner.GetComponent<blockSpawner>().spawnBlock();

            middleMiddleSpawner.GetComponent<blockSpawner>().spawnBlock();
            

        }
    }
}
