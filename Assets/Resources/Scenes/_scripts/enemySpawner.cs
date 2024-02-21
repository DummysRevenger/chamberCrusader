using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public System.Random random = new System.Random();

    public GameObject bloodGoblin;

    public GameObject bigSkeleton;

    public GameObject bloodDragon;

    public GameObject bloodSludge;

    public GameObject meleeEnemyPrefab;

    public GameObject rangedEnemyPrefab;

    public GameObject spider;

    public GameObject dragon;

    public GameObject sandDragon;

    public GameObject scorpion;

    public GameObject cactusGoblin;

    public GameObject sandPile;

    public GameObject bloodSpider;

    public GameObject ghostEnemy;


    // Start is called before the first frame update
    void Start()
    {
        

        if (selectCharacter.mapSelected == "blood")
        {
            meleeEnemyPrefab = bloodGoblin;
            rangedEnemyPrefab = bloodSludge;

            dragon = bloodDragon;

            spider = bloodSpider;

        }
        else if (selectCharacter.mapSelected == "desert")
        {
            meleeEnemyPrefab = cactusGoblin;
            rangedEnemyPrefab = sandPile;

            spider = scorpion;

            dragon = sandDragon;
        }

        if (spider == null)
        {
            spider = dragon;
        }

        if (dragon == null)
        {
            spider = meleeEnemyPrefab;
        }


    }

    public void spawnEnemy()
    {
        int enemyType = random.Next(0, 5);
        if (gameObject.name.Contains("bottom") || gameObject.name.Contains("middle"))
        {
            

            switch (enemyType)
            {
                case 0:
                    Instantiate(meleeEnemyPrefab, transform.position, Quaternion.identity);
                    Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                    break;
                case 1:
                    Instantiate(meleeEnemyPrefab, transform.position, Quaternion.identity);

                    int randomX = random.Next(-2, 0);


                    Vector3 offset = new Vector3(randomX, -1, 0f);
                    Vector3 finalSpawnPosition = transform.position + offset;

                    Instantiate(meleeEnemyPrefab, finalSpawnPosition, Quaternion.identity);

                    finalSpawnPosition = transform.position - offset;

                    Instantiate(meleeEnemyPrefab, finalSpawnPosition, Quaternion.identity);

                    


                    break;
                case 2:

                    if (spider != null)
                    {
                        Instantiate(spider, transform.position, Quaternion.identity);
                    }
                    else if (dragon != null){
                        Instantiate(dragon, transform.position, Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(meleeEnemyPrefab, transform.position, Quaternion.identity);
                        Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                    }


                    
                    break;
                case 3:
                    Instantiate(ghostEnemy, transform.position, Quaternion.identity);
                    break;
                default:
                    break;
            }
        }
        else
        {
            switch(enemyType)
            {
                case 0:
                    Instantiate(rangedEnemyPrefab, transform.position, Quaternion.identity);

                    int randomX = random.Next(-2, 0);


                    Vector3 offset = new Vector3(randomX, -1, 0f);
                    Vector3 finalSpawnPosition = transform.position + offset;

                    Instantiate(rangedEnemyPrefab, finalSpawnPosition, Quaternion.identity);

                    finalSpawnPosition = transform.position - offset;

                    Instantiate(rangedEnemyPrefab, finalSpawnPosition, Quaternion.identity);
                    break;

                case 1:
                    Instantiate(rangedEnemyPrefab, transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(meleeEnemyPrefab, transform.position, Quaternion.identity);
                    break;
                case 3:

                    if (spider != null)
                    {
                        Instantiate(spider, transform.position, Quaternion.identity);
                    }
                    else if (dragon != null) {
                        Instantiate(dragon, transform.position, Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(meleeEnemyPrefab, transform.position, Quaternion.identity);
                        Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                    }
                    break;


                case 4:
                    Instantiate(ghostEnemy, transform.position, Quaternion.identity);

                    break;
            }
        }
        

    }
    // Update is called once per frame
    void Update()
    {
        int roomNo = nextRoomChecker.S.roomNumber;


        
        


        

        

    }
}
