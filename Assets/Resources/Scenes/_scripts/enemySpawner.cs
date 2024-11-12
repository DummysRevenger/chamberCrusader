using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public System.Random random = new System.Random();

    private GameObject tipCreature1;
    private GameObject tipCreature2;
    private GameObject tipCreature3;
    private GameObject tipCreature4;
    private GameObject tipCreature5;
    private GameObject tipCreature6;
    private GameObject tipCreature7;
    private GameObject tipCreature8;
    private GameObject tipCreature9;

    

    public GameObject bigSkeletonPrefab;

    public GameObject bigSkeleton;

    public GameObject bloodDragon;

    

    public GameObject meleeEnemyPrefab;

    public GameObject rangedEnemyPrefab;

    public GameObject spider;

    public GameObject spiderPrefab;

    public GameObject dragon;

    public GameObject sandDragon;

    public GameObject scorpion;

    public GameObject cactusGoblin;

    public GameObject sandPile;

    public GameObject bloodSpider;

    public GameObject ghostEnemy;

    public GameObject theSnake;

    public GameObject ghostEnemyPrefab;
    

    public GameObject anubis;

    public GameObject pyramid;

    public GameObject pyramidSpawnPoint;

    


    //onion city enemies

    public GameObject rangedGangsta;

    public GameObject meleeGangsta;

    public GameObject zombieGangsta1;

    public GameObject zombieGangsta2;

    public GameObject houndDog;

    public GameObject zombieDog;


    // new strong enemies

    

    private GameObject infectedKnight;


    // placeholder
    private GameObject strongEnemy;

    private GameObject normalSludge;

    private GameObject normalGoblin;

    // retribution -----

    // vestibule
    private GameObject wasp;
    private GameObject hornet;
    private GameObject worm;
    private GameObject waspHive;
    private GameObject maggot;

    // limbo
    private GameObject caveSpider;
    private GameObject crawlingSnake;

    // lust
    private GameObject tornado;
    private GameObject wyvern;
    private GameObject evilEyes;
    private GameObject hailGolem;

    //muddy
    private GameObject mudMan;
    private GameObject sludgeElemental;
    private GameObject sludgySludge;

    // greedy
    private GameObject gildedHorror;
    private GameObject goldPool;
    private GameObject auricLeviathan;


    // angry
    private GameObject croc;
    private GameObject frog;
    private GameObject trapPlant;
    private GameObject poisonPlant;
    public GameObject necromancer;



    //fire
    private GameObject fireDemon;
    private GameObject fireElemental;
    private GameObject fireSludge;

    // violence
    public GameObject thrombus;
    private GameObject bloodGoblin;
    private GameObject bloodSludge;
    private GameObject bloodSkull;
    private GameObject strongZombie;

    // dark
    public GameObject abyssalHorror;
    private GameObject soulEater;
    private GameObject wraith;
    private GameObject viperFish;
    private GameObject blackHole;



    // ice
    private GameObject iceBlock;
    private GameObject yetiDemon;
    private GameObject iceElemental;

    public GameObject abyssalSpawnPoint;


    // Start is called before the first frame update
    void Start()
    {



        spiderPrefab = Resources.Load("Scenes/prefabs/enemies/spidersentryspritesheet_0") as GameObject;

        // retribution enemies

        // vestibule
        wasp = Resources.Load("Scenes/update12Resources/theVestibule/waspEnemy") as GameObject;
        waspHive = Resources.Load("Scenes/update12Resources/theVestibule/waspHive") as GameObject;
        worm = Resources.Load("Scenes/update12Resources/theVestibule/wormEnemy") as GameObject;
        maggot = Resources.Load("Scenes/update12Resources/theVestibule/maggotEnemy") as GameObject;
        hornet = Resources.Load("Scenes/update12Resources/theVestibule/enemyHornet") as GameObject;


        // caves
        caveSpider = Resources.Load("Scenes/update12Resources/limbocaves/prefab/caveSpider") as GameObject;
        crawlingSnake = Resources.Load("Scenes/update12Resources/limbocaves/prefab/crawlingSnake") as GameObject;

        


        // storm
        evilEyes = Resources.Load("Scenes/update12Resources/luststorm/evilEyes") as GameObject;
        hailGolem = Resources.Load("Scenes/update12Resources/luststorm/hailGolem") as GameObject;
        wyvern = Resources.Load("Scenes/update12Resources/luststorm/wyvern") as GameObject;
        tornado = Resources.Load("Scenes/update12Resources/luststorm/miniTornadoHazard") as GameObject;



        // muddy
        mudMan = Resources.Load("Scenes/update12Resources/muddygluttony/mudMan") as GameObject;
        sludgySludge = Resources.Load("Scenes/update12Resources/muddygluttony/sludgySludge") as GameObject;
        sludgeElemental = Resources.Load("Scenes/update12Resources/muddygluttony/sludgeElemental") as GameObject;
        


        //greedy
        auricLeviathan = Resources.Load("Scenes/update12Resources/goldengreed/auricLeviathan") as GameObject;
        gildedHorror = Resources.Load("Scenes/update12Resources/goldengreed/gildedHorror") as GameObject;
        goldPool = Resources.Load("Scenes/update12Resources/goldengreed/goldPool") as GameObject;



        // angry
        croc = Resources.Load("Scenes/update12Resources/swamp/crocodileObject") as GameObject;
        frog = Resources.Load("Scenes/update12Resources/swamp/giantFrogObject") as GameObject;
        trapPlant = Resources.Load("Scenes/update12Resources/swamp/trapPlant") as GameObject;
        poisonPlant = Resources.Load("Scenes/update12Resources/swamp/poisonousPlantObject") as GameObject;



        // fire
        fireDemon = Resources.Load("Scenes/update12Resources/fireOfHeresy/fireDemon2") as GameObject;
        fireSludge = Resources.Load("Scenes/update12Resources/fireOfHeresy/fireSludge") as GameObject;
        fireElemental = Resources.Load("Scenes/update12Resources/fireOfHeresy/fireElemental") as GameObject;


        // violence 
        

        // dark
        wraith = Resources.Load("Scenes/update12Resources/darkFraud/voidWraith") as GameObject;
        soulEater = Resources.Load("Scenes/update12Resources/darkFraud/soulEater") as GameObject;
        viperFish = Resources.Load("Scenes/update12Resources/darkFraud/viperFish") as GameObject;
        blackHole = Resources.Load("Scenes/update12Resources/darkFraud/blackHole") as GameObject;
        abyssalHorror = Resources.Load("Scenes/update12Resources/darkFraud/abyssalHorror") as GameObject;

        // ice

        iceBlock = Resources.Load("Scenes/update12Resources/treacherousIce/enemyIceBlock") as GameObject;
        yetiDemon = Resources.Load("Scenes/update12Resources/treacherousIce/yetiDemon") as GameObject;
        iceElemental = Resources.Load("Scenes/update12Resources/treacherousIce/iceElemental") as GameObject;




        ghostEnemyPrefab = ghostEnemy;

        



        scorpion = Resources.Load("Scenes/update12Resources/scorpionsentry") as GameObject;

        string bloodSpiderPath = "Scenes/prefabs/bloodspidersentry";

        string houndDogPath = "Scenes/update11Resources/theonioncity/prefabs/houndDog";
        string meleeGangstaPath = "Scenes/update11Resources/theonioncity/prefabs/meleeGangsta";
        string rangedGangstaPath = "Scenes/update11Resources/theonioncity/prefabs/rangedGangsta";
        string zombieHoundPath = "Scenes/update11Resources/theonioncity/prefabs/zombieHound";

        string infectedKnightPath = "Scenes/update11Resources/newprefabs/paladinObject";

        string bloodSkullPath = "Scenes/update11Resources/newprefabs/bloodSkull";

        string zombieGangsta1Path = "Scenes/update11Resources/theonioncity/meleeGangstaZombie";
        string zombieGangsta2Path = "Scenes/update11Resources/theonioncity/zombieGangstaRanged";

        string strongZombiePath = "Scenes/update11Resources/newPrefabs/strongZombie";

        string sandPilePath = "Scenes/prefabs/rangedEnemysand";

        string bloodSludgePath = "Scenes/prefabs/enemies/rangedBlood";

        string bloodGoblinPath = "Scenes/prefabs/enemies/bloodGoblin";

        

        bigSkeletonPrefab = bigSkeleton;

        bloodGoblin = Resources.Load(bloodGoblinPath) as GameObject;


        bloodSpider = Resources.Load(bloodSpiderPath) as GameObject;

        bloodSludge = Resources.Load(bloodSludgePath) as GameObject;
        sandPile = Resources.Load(sandPilePath) as GameObject;

        houndDog = Resources.Load(houndDogPath) as GameObject;
        meleeGangsta = Resources.Load(meleeGangstaPath) as GameObject;
        rangedGangsta = Resources.Load(rangedGangstaPath) as GameObject;
        zombieDog = Resources.Load(zombieHoundPath) as GameObject;

        infectedKnight = Resources.Load(infectedKnightPath) as GameObject;

        bloodSkull = Resources.Load(bloodSkullPath) as GameObject;

        zombieGangsta1 = Resources.Load(zombieGangsta1Path) as GameObject;

        zombieGangsta2 = Resources.Load(zombieGangsta2Path) as GameObject;

        strongZombie = Resources.Load(strongZombiePath) as GameObject;

        normalGoblin = Resources.Load("Scenes/prefabs/enemies/normalGoblin") as GameObject;

        normalSludge = Resources.Load("Scenes/prefabs/enemies/rangedEnemy") as GameObject;

        tipCreature1 = Resources.Load("Scenes/update12Resources/tipCreatures/tipCreature1") as GameObject;
        tipCreature2 = Resources.Load("Scenes/update12Resources/tipCreatures/tipCreature2") as GameObject;
        tipCreature3 = Resources.Load("Scenes/update12Resources/tipCreatures/tipCreature3") as GameObject;
        tipCreature4 = Resources.Load("Scenes/update12Resources/tipCreatures/tipCreature4") as GameObject;
        tipCreature5 = Resources.Load("Scenes/update12Resources/tipCreatures/tipCreature5") as GameObject;
        tipCreature6 = Resources.Load("Scenes/update12Resources/tipCreatures/tipCreature6") as GameObject;
        tipCreature7 = Resources.Load("Scenes/update12Resources/tipCreatures/tipCreature7") as GameObject;
        tipCreature8 = Resources.Load("Scenes/update12Resources/tipCreatures/tipCreature8") as GameObject;
        tipCreature9 = Resources.Load("Scenes/update12Resources/tipCreatures/tipCreature9") as GameObject;





        if (spider == null)
        {
            spider = dragon;
        }

        if (dragon == null)
        {
            dragon = spider;
        }



        setEnemies();

    }

    public void spawnEnemy()
    {


        if (gameObject.name == "topLeftSpawner")
        {
            if (selectCharacter.mapSelected == "dungeon" && nextRoomChecker.S.roomNumber == 15)
            {
                Instantiate(tipCreature9, transform.position, transform.rotation);
            }
            else
            {

                if (nextRoomChecker.S.roomNumber % 7 == 0)
                {
                    int randomValue = random.Next(1, 10);

                    if (randomValue == 9)
                    {

                        if (tipUnlockStore.lockedTips.Count > 0)
                        {
                            int tipCreatureNumber = tipUnlockStore.lockedTips[0];

                            string tipCreatureObjectString = "tipCreature" + tipCreatureNumber;

                            GameObject objectToSpawn = Resources.Load("Scenes/update12Resources/tipCreatures/" + tipCreatureObjectString) as GameObject;

                            Instantiate(objectToSpawn, transform.position, transform.rotation);


                        }
                    }
                    else
                    {
                        string tipCreatureValue = "tipCreature" + randomValue;

                        GameObject objectToSpawn = Resources.Load("Scenes/update12Resources/tipCreatures/" + tipCreatureValue) as GameObject;

                        Instantiate(objectToSpawn, transform.position, transform.rotation);
                    }


                }

            }



        }



        if (nextRoomChecker.S.roomNumber != 20 && nextRoomChecker.S.roomNumber != 90
            && nextRoomChecker.S.roomNumber != 80 &&
            nextRoomChecker.S.roomNumber != 100
            && nextRoomChecker.S.roomNumber != 10 && nextRoomChecker.S.roomNumber % 15 != 0
            && nextRoomChecker.S.roomNumber != 59 && nextRoomChecker.S.roomNumber != 89)
        {

            int enemyType = random.Next(0, 7);
            if (gameObject.name.Contains("middle"))
            {

                int randomX = random.Next(-2, 0);
                Vector3 offset = new Vector3(randomX, -1, 0f);
                Vector3 finalSpawnPosition = transform.position + offset;

                switch (enemyType)
                {
                    case 0:

                        switch(enemySpawnDifficultyStore.S.difficulty)
                        {
                            case "easy":
                                Instantiate(meleeEnemyPrefab, transform.position, Quaternion.identity);
                                break;
                            case "medium":
                                Instantiate(meleeEnemyPrefab, transform.position, Quaternion.identity);
                                Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                break;
                            case "hard":
                                Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                break;
                            case "insane":
                                Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                Instantiate(meleeEnemyPrefab, transform.position, Quaternion.identity);
                                break;
                                
                        }
                        

                        

                        break;
                    case 1:

                        


                        switch (enemySpawnDifficultyStore.S.difficulty)
                        {
                            case "easy":
                                Instantiate(meleeEnemyPrefab, transform.position, Quaternion.identity);
                                break;
                            case "medium":
                                Instantiate(meleeEnemyPrefab, transform.position, Quaternion.identity);
                                Instantiate(meleeEnemyPrefab, transform.position, Quaternion.identity);
                                break;
                            case "hard":
                                Instantiate(meleeEnemyPrefab, transform.position, Quaternion.identity);

                                Instantiate(meleeEnemyPrefab, finalSpawnPosition, Quaternion.identity);

                                finalSpawnPosition = transform.position - offset;

                                Instantiate(meleeEnemyPrefab, finalSpawnPosition, Quaternion.identity);
                                break;
                            case "insane":
                                Instantiate(meleeEnemyPrefab, transform.position, Quaternion.identity);

                                


                                

                                Instantiate(meleeEnemyPrefab, finalSpawnPosition, Quaternion.identity);

                                finalSpawnPosition = transform.position - offset;

                                Instantiate(meleeEnemyPrefab, finalSpawnPosition, Quaternion.identity);

                                Instantiate(meleeEnemyPrefab, finalSpawnPosition, Quaternion.identity);

                                Instantiate(meleeEnemyPrefab, finalSpawnPosition, Quaternion.identity);

                                Instantiate(meleeEnemyPrefab, finalSpawnPosition, Quaternion.identity);
                                break;
                        }


                        




                        break;
                    case 2:

                        switch (enemySpawnDifficultyStore.S.difficulty)
                        {
                            case "easy":
                                Instantiate(bigSkeleton, transform.position, Quaternion.identity);

                                if (dragon != null && (gameObject.name.Contains("Left") || gameObject.name.Contains("Right")))
                                {
                                    Instantiate(dragon, transform.position, Quaternion.identity);
                                    Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                }
                                break;
                            case "medium":
                                if (spider != null && (gameObject.name.Contains("Left") || gameObject.name.Contains("Right")))
                                {
                                    Instantiate(spider, transform.position, Quaternion.identity);
                                }
                                else if (dragon != null && (gameObject.name.Contains("Left") || gameObject.name.Contains("Right")))
                                {
                                    Instantiate(dragon, transform.position, Quaternion.identity);
                                }
                                else
                                {
                                    Instantiate(meleeEnemyPrefab, transform.position, Quaternion.identity);
                                    Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                }
                                break;
                            case "hard":
                                if (spider != null && (gameObject.name.Contains("Left") || gameObject.name.Contains("Right")))
                                {
                                    Instantiate(spider, transform.position, Quaternion.identity);
                                    
                                }
                                else if (dragon != null && (gameObject.name.Contains("Left") || gameObject.name.Contains("Right")))
                                {
                                    Instantiate(dragon, transform.position, Quaternion.identity);
                                    Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                }
                                else
                                {
                                    Instantiate(meleeEnemyPrefab, transform.position, Quaternion.identity);
                                    Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                }
                                break;
                            case "insane":
                                if (spider != null && (gameObject.name.Contains("Left") || gameObject.name.Contains("Right")))
                                {
                                    
                                    Instantiate(spider, transform.position, Quaternion.identity);
                                    Instantiate(dragon, transform.position, Quaternion.identity);
                                }
                                else if (dragon != null && (gameObject.name.Contains("Left") || gameObject.name.Contains("Right")))
                                {
                                    Instantiate(dragon, transform.position, Quaternion.identity);
                                    Instantiate(dragon, transform.position, Quaternion.identity);
                                    Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                }
                                else
                                {
                                    Instantiate(meleeEnemyPrefab, transform.position, Quaternion.identity);
                                    Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                    Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                    Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                }
                                break;
                        }

                        



                        break;
                    case 3:
                        

                        switch (enemySpawnDifficultyStore.S.difficulty)
                        {
                            case "easy":
                                Instantiate(ghostEnemy, transform.position, Quaternion.identity);
                                break;
                            case "medium":
                                Instantiate(ghostEnemy, transform.position, Quaternion.identity);
                                Instantiate(ghostEnemy, transform.position, Quaternion.identity);
                                break;
                            case "hard":
                                Instantiate(ghostEnemy, transform.position, Quaternion.identity);
                                Instantiate(ghostEnemy, transform.position, Quaternion.identity);
                                Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                break;
                            case "insane":
                                Instantiate(ghostEnemy, transform.position, Quaternion.identity);
                                Instantiate(ghostEnemy, transform.position, Quaternion.identity);
                                Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                Instantiate(ghostEnemy, transform.position, Quaternion.identity);
                                Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                break;
                        }
                        break;
                    case 4:
                        if (spider != null && gameObject.name.Contains("Left") && gameObject.name.Contains("Right"))
                        {
                            

                            switch (enemySpawnDifficultyStore.S.difficulty)
                            {
                                case "easy":
                                    Instantiate(spider, transform.position, Quaternion.identity);
                                    break;
                                case "medium":
                                    Instantiate(ghostEnemy, transform.position, Quaternion.identity);
                                    
                                    break;
                                case "hard":
                                    Instantiate(ghostEnemy, transform.position, Quaternion.identity);
                                    Instantiate(ghostEnemy, transform.position, Quaternion.identity);
                                    
                                    break;
                                case "insane":
                                    Instantiate(ghostEnemy, transform.position, Quaternion.identity);
                                    Instantiate(ghostEnemy, transform.position, Quaternion.identity);
                                    Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                    
                                    Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                    break;
                            }
                        }
                        break;
                    case 5:

                        switch (enemySpawnDifficultyStore.S.difficulty)
                        {
                            case "easy":
                                Instantiate(rangedEnemyPrefab, transform.position, Quaternion.identity);
                                Instantiate(rangedEnemyPrefab, transform.position, Quaternion.identity);
                                break;
                            case "medium":
                                if (nextRoomChecker.S.roomNumber >= 15)
                                {
                                    Instantiate(strongEnemy, transform.position, Quaternion.identity);
                                }
                                Instantiate(rangedEnemyPrefab, transform.position, Quaternion.identity);
                                Instantiate(rangedEnemyPrefab, transform.position, Quaternion.identity);
                                break;
                            case "hard":
                                if (nextRoomChecker.S.roomNumber >= 15)
                                {
                                    Instantiate(strongEnemy, transform.position, Quaternion.identity);
                                }
                                Instantiate(rangedEnemyPrefab, transform.position, Quaternion.identity);
                                Instantiate(rangedEnemyPrefab, transform.position, Quaternion.identity);
                                Instantiate(rangedEnemyPrefab, transform.position, Quaternion.identity);
                                break;
                            case "insane":
                                Instantiate(strongEnemy, transform.position, Quaternion.identity);
                                Instantiate(strongEnemy, transform.position, Quaternion.identity);
                                Instantiate(rangedEnemyPrefab, transform.position, Quaternion.identity);
                                break;
                        }


                        
                        break;
                    case 6:

                        if (nextRoomChecker.S.roomNumber >= 15)
                        {
                            


                            switch (enemySpawnDifficultyStore.S.difficulty)
                            {
                                case "easy":
                                    Instantiate(strongEnemy, transform.position, Quaternion.identity);
                                    break;
                                case "medium":
                                    Instantiate(meleeEnemyPrefab, transform.position, Quaternion.identity);
                                    Instantiate(meleeEnemyPrefab, transform.position, Quaternion.identity);
                                    Instantiate(strongEnemy, transform.position, Quaternion.identity);
                                    break;
                                case "hard":
                                    Instantiate(meleeEnemyPrefab, transform.position, Quaternion.identity);

                                    Instantiate(meleeEnemyPrefab, finalSpawnPosition, Quaternion.identity);

                                    

                                    Instantiate(meleeEnemyPrefab, finalSpawnPosition, Quaternion.identity);
                                    Instantiate(strongEnemy, transform.position, Quaternion.identity);
                                    break;
                                case "insane":
                                    Instantiate(meleeEnemyPrefab, transform.position, Quaternion.identity);


                                    Instantiate(strongEnemy, transform.position, Quaternion.identity);
                                    Instantiate(strongEnemy, transform.position, Quaternion.identity);



                                    Instantiate(meleeEnemyPrefab, finalSpawnPosition, Quaternion.identity);

                                    finalSpawnPosition = transform.position - offset;

                                    Instantiate(meleeEnemyPrefab, finalSpawnPosition, Quaternion.identity);

                                    Instantiate(meleeEnemyPrefab, finalSpawnPosition, Quaternion.identity);

                                    Instantiate(meleeEnemyPrefab, finalSpawnPosition, Quaternion.identity);

                                    Instantiate(meleeEnemyPrefab, finalSpawnPosition, Quaternion.identity);
                                    break;
                            }
                        }





                        
                        break;


                    default:
                        break;
                }
            }
            else if (gameObject.name.Contains("top"))
            {

                int randomX = random.Next(-2, 0);
                Vector3 offset = new Vector3(randomX, -1, 0f);
                Vector3 finalSpawnPosition = transform.position + offset;

                switch (enemyType)
                {

                    case 0:

                        switch (enemySpawnDifficultyStore.S.difficulty)
                        {
                            case "easy":
                                Instantiate(spider, transform.position, Quaternion.identity);
                                Instantiate(strongEnemy, transform.position, Quaternion.identity);
                                break;
                            case "medium":
                                Instantiate(rangedEnemyPrefab, transform.position, Quaternion.identity);

                                Instantiate(strongEnemy, transform.position, Quaternion.identity);



                                Instantiate(rangedEnemyPrefab, finalSpawnPosition, Quaternion.identity);

                                Instantiate(strongEnemy, transform.position, Quaternion.identity);

                                finalSpawnPosition = transform.position - offset;

                                Instantiate(rangedEnemyPrefab, finalSpawnPosition, Quaternion.identity);
                                break;
                            case "hard":

                                Vector3 offsetHard = new Vector3(3f, 0f, 0f);

                                Instantiate(ghostEnemy, transform.position, Quaternion.identity);
                                Instantiate(rangedEnemyPrefab, transform.position, Quaternion.identity);
                                Instantiate(rangedEnemyPrefab, transform.position + offsetHard, Quaternion.identity);
                                Instantiate(rangedEnemyPrefab, transform.position - offsetHard, Quaternion.identity);
                                Instantiate(spider, transform.position, Quaternion.identity);

                                Instantiate(strongEnemy, transform.position, Quaternion.identity);
                                break;
                            case "insane":

                                Vector3 offsetInsane1 = new Vector3(3f, 0f, 0f);
                                Vector3 offsetInsane2 = new Vector3(3f, 0f, 0f);
                                Instantiate(ghostEnemy, transform.position, Quaternion.identity);
                                Instantiate(ghostEnemy, transform.position, Quaternion.identity);
                                
                                Instantiate(rangedEnemyPrefab, transform.position, Quaternion.identity);
                                Instantiate(rangedEnemyPrefab, transform.position + offsetInsane2, Quaternion.identity);
                                Instantiate(rangedEnemyPrefab, transform.position - offsetInsane1, Quaternion.identity);

                                Instantiate(strongEnemy, transform.position, Quaternion.identity);
                                break;
                        }


                        break;

                    case 1:

                        switch (enemySpawnDifficultyStore.S.difficulty)
                        {
                            case "easy":
                                Instantiate(spider, transform.position, Quaternion.identity);
                                Instantiate(strongEnemy, transform.position, Quaternion.identity);
                                break;
                            case "medium":
                                Instantiate(rangedEnemyPrefab, transform.position, Quaternion.identity);

                                Instantiate(strongEnemy, transform.position, Quaternion.identity);

                                Instantiate(rangedEnemyPrefab, finalSpawnPosition, Quaternion.identity);

                                finalSpawnPosition = transform.position - offset;

                                Instantiate(rangedEnemyPrefab, finalSpawnPosition, Quaternion.identity);
                                break;
                            case "hard":

                                Vector3 offsetHard = new Vector3(3f, 0f, 0f);

                                Instantiate(ghostEnemy, transform.position, Quaternion.identity);
                                Instantiate(rangedEnemyPrefab, transform.position, Quaternion.identity);
                                Instantiate(rangedEnemyPrefab, transform.position + offsetHard, Quaternion.identity);
                                Instantiate(rangedEnemyPrefab, transform.position - offsetHard, Quaternion.identity);
                                Instantiate(spider, transform.position, Quaternion.identity);

                                break;
                            case "insane":

                                Vector3 offsetInsane1 = new Vector3(3f, 0f, 0f);
                                Vector3 offsetInsane2 = new Vector3(3f, 0f, 0f);
                                Instantiate(ghostEnemy, transform.position, Quaternion.identity);
                                Instantiate(ghostEnemy, transform.position, Quaternion.identity);

                                Instantiate(rangedEnemyPrefab, transform.position, Quaternion.identity);
                                Instantiate(rangedEnemyPrefab, transform.position + offsetInsane2, Quaternion.identity);
                                Instantiate(rangedEnemyPrefab, transform.position - offsetInsane1, Quaternion.identity);
                                Instantiate(rangedEnemyPrefab, transform.position + offsetInsane1, Quaternion.identity);
                                Instantiate(rangedEnemyPrefab, transform.position - offsetInsane2, Quaternion.identity);
                                break;
                        }



                        break;
                    case 2:

                        

                        switch (enemySpawnDifficultyStore.S.difficulty)
                        {
                            case "easy":
                                Instantiate(strongEnemy, transform.position, Quaternion.identity);
                                break;
                            case "medium":
                                Instantiate(meleeEnemyPrefab, transform.position, Quaternion.identity);
                                Instantiate(meleeEnemyPrefab, transform.position, Quaternion.identity);
                                Instantiate(strongEnemy, transform.position, Quaternion.identity);
                                break;
                            case "hard":
                                Instantiate(meleeEnemyPrefab, transform.position, Quaternion.identity);

                                Instantiate(meleeEnemyPrefab, finalSpawnPosition, Quaternion.identity);

                                Instantiate(strongEnemy, transform.position, Quaternion.identity);

                                finalSpawnPosition = transform.position - offset;

                                Instantiate(meleeEnemyPrefab, finalSpawnPosition, Quaternion.identity);
                                break;
                            case "insane":
                                Instantiate(meleeEnemyPrefab, transform.position, Quaternion.identity);

                                Instantiate(meleeEnemyPrefab, finalSpawnPosition, Quaternion.identity);

                                Instantiate(strongEnemy, transform.position, Quaternion.identity);

                                finalSpawnPosition = transform.position - offset;

                                Instantiate(meleeEnemyPrefab, finalSpawnPosition, Quaternion.identity);

                                Instantiate(meleeEnemyPrefab, finalSpawnPosition, Quaternion.identity);

                                Instantiate(meleeEnemyPrefab, finalSpawnPosition, Quaternion.identity);

                                Instantiate(meleeEnemyPrefab, finalSpawnPosition, Quaternion.identity);
                                break;
                        }
                        break;
                    case 3:

                        switch (enemySpawnDifficultyStore.S.difficulty)
                        {
                            case "easy":

                                if (dragon != null && (gameObject.name.Contains("Left") || gameObject.name.Contains("Right")))
                                {
                                    Instantiate(dragon, transform.position, Quaternion.identity);
                                    Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                }


                                Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                break;
                            case "medium":
                                if (spider != null && gameObject.name.Contains("Left") && gameObject.name.Contains("Right"))
                                {
                                    Instantiate(spider, transform.position, Quaternion.identity);
                                }
                                else if (dragon != null && gameObject.name.Contains("Left") && gameObject.name.Contains("Right"))
                                {
                                    Instantiate(dragon, transform.position, Quaternion.identity);
                                }
                                else
                                {
                                    Instantiate(meleeEnemyPrefab, transform.position, Quaternion.identity);
                                    Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                }

                                Instantiate(strongEnemy, transform.position, Quaternion.identity);
                                break;
                            case "hard":
                                Instantiate(strongEnemy, transform.position, Quaternion.identity);
                                if (spider != null && gameObject.name.Contains("Left") && gameObject.name.Contains("Right"))
                                {
                                    Instantiate(spider, transform.position, Quaternion.identity);
                                }
                                else if (dragon != null && (gameObject.name.Contains("Left") || gameObject.name.Contains("Right")))
                                {
                                    Instantiate(dragon, transform.position, Quaternion.identity);
                                    Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                }
                                else
                                {
                                    Instantiate(meleeEnemyPrefab, transform.position, Quaternion.identity);
                                    Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                }
                                break;
                            case "insane":

                                Instantiate(strongEnemy, transform.position, Quaternion.identity);

                                if (spider != null && (gameObject.name.Contains("Left") || gameObject.name.Contains("Right")))
                                {
                                    Instantiate(spider, transform.position, Quaternion.identity);
                                    
                                    Instantiate(dragon, transform.position, Quaternion.identity);
                                }
                                else if (dragon != null && (gameObject.name.Contains("Left") || gameObject.name.Contains("Right")))
                                {
                                    Instantiate(dragon, transform.position, Quaternion.identity);
                                    Instantiate(dragon, transform.position, Quaternion.identity);
                                    Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                }
                                else
                                {
                                    Instantiate(meleeEnemyPrefab, transform.position, Quaternion.identity);
                                    Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                    Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                    Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                }
                                break;
                        }
                        break;


                    case 4:

                        switch (enemySpawnDifficultyStore.S.difficulty)
                        {
                            case "easy":
                                Instantiate(spider, transform.position, Quaternion.identity);
                                break;
                            case "medium":
                                Instantiate(rangedEnemyPrefab, transform.position, Quaternion.identity);

                                Instantiate(strongEnemy, transform.position, Quaternion.identity);


                                Instantiate(rangedEnemyPrefab, finalSpawnPosition, Quaternion.identity);

                                finalSpawnPosition = transform.position - offset;

                                Instantiate(rangedEnemyPrefab, finalSpawnPosition, Quaternion.identity);
                                break;
                            case "hard":

                                Vector3 offsetHard = new Vector3(3f, 0f, 0f);

                                Instantiate(ghostEnemy, transform.position, Quaternion.identity);
                                Instantiate(rangedEnemyPrefab, transform.position, Quaternion.identity);
                                Instantiate(rangedEnemyPrefab, transform.position + offsetHard, Quaternion.identity);
                                Instantiate(rangedEnemyPrefab, transform.position - offsetHard, Quaternion.identity);
                                Instantiate(spider, transform.position, Quaternion.identity);

                                Instantiate(strongEnemy, transform.position, Quaternion.identity);
                                break;
                            case "insane":

                                Vector3 offsetInsane1 = new Vector3(3f, 0f, 0f);
                                Vector3 offsetInsane2 = new Vector3(3f, 0f, 0f);
                                Instantiate(ghostEnemy, transform.position, Quaternion.identity);
                                Instantiate(ghostEnemy, transform.position, Quaternion.identity);

                                Instantiate(rangedEnemyPrefab, transform.position, Quaternion.identity);
                                Instantiate(rangedEnemyPrefab, transform.position + offsetInsane2, Quaternion.identity);
                                Instantiate(rangedEnemyPrefab, transform.position - offsetInsane1, Quaternion.identity);
                                Instantiate(rangedEnemyPrefab, transform.position + offsetInsane1, Quaternion.identity);
                                Instantiate(rangedEnemyPrefab, transform.position - offsetInsane2, Quaternion.identity);

                                Instantiate(strongEnemy, transform.position, Quaternion.identity);
                                break;
                        }

                        break;

                    case 5:
                        switch (enemySpawnDifficultyStore.S.difficulty)
                        {
                            case "easy":
                                Instantiate(bigSkeleton, transform.position, Quaternion.identity);

                                if (dragon != null && (gameObject.name.Contains("Left") || gameObject.name.Contains("Right")))
                                {
                                    Instantiate(dragon, transform.position, Quaternion.identity);
                                    Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                }
                                break;
                            case "medium":
                                if (spider != null && gameObject.name.Contains("Left") && gameObject.name.Contains("Right"))
                                {
                                    Instantiate(spider, transform.position, Quaternion.identity);
                                }
                                else if (dragon != null && (gameObject.name.Contains("Left") || gameObject.name.Contains("Right")))
                                {
                                    Instantiate(dragon, transform.position, Quaternion.identity);
                                }
                                else
                                {
                                    Instantiate(meleeEnemyPrefab, transform.position, Quaternion.identity);
                                    Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                }

                                Instantiate(strongEnemy, transform.position, Quaternion.identity);
                                break;
                            case "hard":
                                if (spider != null && (gameObject.name.Contains("Left") || gameObject.name.Contains("Right")))
                                {
                                    
                                    Instantiate(spider, transform.position, Quaternion.identity);
                                }
                                else if (dragon != null && (gameObject.name.Contains("Left") || gameObject.name.Contains("Right")))
                                {
                                    Instantiate(dragon, transform.position, Quaternion.identity);
                                    Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                }
                                else
                                {
                                    Instantiate(meleeEnemyPrefab, transform.position, Quaternion.identity);
                                    Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                }

                                Instantiate(strongEnemy, transform.position, Quaternion.identity);
                                break;
                            case "insane":
                                if (spider != null && (gameObject.name.Contains("Left") || gameObject.name.Contains("Right")))
                                {
                                    Instantiate(spider, transform.position, Quaternion.identity);
                                    
                                    Instantiate(dragon, transform.position, Quaternion.identity);
                                }
                                else if (dragon != null && (gameObject.name.Contains("Left") || gameObject.name.Contains("Right")))
                                {
                                    Instantiate(dragon, transform.position, Quaternion.identity);
                                    Instantiate(dragon, transform.position, Quaternion.identity);
                                    Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                }
                                else
                                {
                                    Instantiate(meleeEnemyPrefab, transform.position, Quaternion.identity);
                                    Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                    Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                    Instantiate(bigSkeleton, transform.position, Quaternion.identity);
                                }

                                Instantiate(strongEnemy, transform.position, Quaternion.identity);
                                break;
                        }
                        break;

                    case 6:
                        switch (enemySpawnDifficultyStore.S.difficulty)
                        {
                            case "easy":
                                Instantiate(rangedEnemyPrefab, transform.position, Quaternion.identity);
                                Instantiate(rangedEnemyPrefab, transform.position, Quaternion.identity);
                                break;
                            case "medium":
                                if (nextRoomChecker.S.roomNumber >= 15)
                                {
                                    Instantiate(strongEnemy, transform.position, Quaternion.identity);
                                }
                                Instantiate(strongEnemy, transform.position, Quaternion.identity);
                                break;
                            case "hard":
                                if (nextRoomChecker.S.roomNumber >= 15)
                                {
                                    Instantiate(strongEnemy, transform.position, Quaternion.identity);
                                }
                                Instantiate(rangedEnemyPrefab, transform.position, Quaternion.identity);
                                Instantiate(rangedEnemyPrefab, transform.position, Quaternion.identity);
                                Instantiate(rangedEnemyPrefab, transform.position, Quaternion.identity);
                                
                                break;
                            case "insane":
                                Instantiate(strongEnemy, transform.position, Quaternion.identity);
                                Instantiate(strongEnemy, transform.position, Quaternion.identity);
                                Instantiate(rangedEnemyPrefab, transform.position, Quaternion.identity);
                                break;
                        }
                        break;

                    default:
                        break;
                }
            }
        }
        else
        {
            

            if (gameObject.name == "topLeftSpawner")
            {

                if (nextRoomChecker.S.roomNumber == 20)
                {
                    switch (selectCharacter.mapSelected)
                    {
                        case "dungeon":
                            // spawn the snake
                            Instantiate(theSnake, transform.position, Quaternion.identity);

                            break;

                        case "blood":
                            // spawn thrombus
                            Instantiate(thrombus, transform.position, Quaternion.identity);
                            break;
                        case "desert":
                            // spawn pyramid stage 4 map
                            Instantiate(pyramid, pyramidSpawnPoint.transform.position, Quaternion.identity);
                            break;
                    }
                }
                else if (nextRoomChecker.S.roomNumber == 60 && retributionMapStore.S.mapType == "angry")
                {
                    Instantiate(necromancer, transform.position, Quaternion.identity);
                }
                else if (nextRoomChecker.S.roomNumber == 80 && retributionMapStore.S.mapType == "violence")
                {
                    Instantiate(thrombus, transform.position, Quaternion.identity);
                }
                else if (nextRoomChecker.S.roomNumber == 90 && retributionMapStore.S.mapType == "dark")
                {
                    Instantiate(abyssalHorror, abyssalSpawnPoint.transform.position, Quaternion.identity);
                }
                else if (nextRoomChecker.S.roomNumber == 100 && retributionMapStore.S.mapType == "ice")
                {
                    //Instantiate(necromancer, transform.position, Quaternion.identity);

                    // summons the devil
                }


            }


        }


    }


    void setEnemies()
    {
        if (selectCharacter.mapSelected == "onion" && nextRoomChecker.S.roomNumber >= 20)
        {
            meleeEnemyPrefab = zombieGangsta1;
            rangedEnemyPrefab = zombieGangsta2;
        }


        if (selectCharacter.mapSelected == "dungeon")
        {
            strongEnemy = infectedKnight;

            meleeEnemyPrefab = normalGoblin;
            rangedEnemyPrefab = normalSludge;
        }
        if (selectCharacter.mapSelected == "blood")
        {

            

            meleeEnemyPrefab = bloodGoblin;
            rangedEnemyPrefab = bloodSludge;

            dragon = bloodDragon;

            spider = bloodSpider;

            strongEnemy = bloodSkull;

        }
        else if (selectCharacter.mapSelected == "desert")
        {
            meleeEnemyPrefab = cactusGoblin;
            rangedEnemyPrefab = sandPile;

            spider = scorpion;

            dragon = sandDragon;


            strongEnemy = anubis;
        }
        else if (selectCharacter.mapSelected == "onion")
        {
            meleeEnemyPrefab = houndDog;
            rangedEnemyPrefab = normalSludge;

            ghostEnemy = houndDog;


            spider = rangedGangsta;


            dragon = meleeGangsta;


            strongEnemy = strongZombie;

        }
        else if (selectCharacter.mapSelected == "retribution")
        {
            switch (nextRoomChecker.S.roomNumber)
            {
                case 0: //vestibule
                    meleeEnemyPrefab = maggot;
                    rangedEnemyPrefab = wasp;

                    spider = waspHive;

                    dragon = worm;

                    strongEnemy = hornet;

                    ghostEnemy = ghostEnemyPrefab;
                    break;
                case 10: //limbo

                    meleeEnemyPrefab = normalGoblin;
                    rangedEnemyPrefab = normalSludge;

                    spider = caveSpider;

                    dragon = crawlingSnake;

                    strongEnemy = spiderPrefab;

                    ghostEnemy = ghostEnemyPrefab;
                    break;
                case 20: // lust

                    meleeEnemyPrefab = normalGoblin;
                    rangedEnemyPrefab = normalSludge;

                    spider = evilEyes;

                    dragon = wyvern;

                    strongEnemy = hailGolem;

                    ghostEnemy = tornado;

                    break;
                case 30: // muddy
                    meleeEnemyPrefab = mudMan;
                    rangedEnemyPrefab = sludgySludge;

                    spider = sludgeElemental;

                    dragon = worm;

                    strongEnemy = sludgeElemental;

                    ghostEnemy = ghostEnemyPrefab;
                    break;
                case 40: // greedy
                    meleeEnemyPrefab = gildedHorror;
                    rangedEnemyPrefab = normalSludge;

                    spider = goldPool;

                    dragon = gildedHorror;

                    strongEnemy = auricLeviathan;

                    ghostEnemy = ghostEnemyPrefab;
                    break;
                case 50: // angry
                    meleeEnemyPrefab = normalGoblin;
                    rangedEnemyPrefab = sludgeElemental;

                    spider = bigSkeletonPrefab;

                    bigSkeleton = frog;

                    dragon = croc;

                    strongEnemy = poisonPlant;

                    ghostEnemy = trapPlant;
                    break;
                case 60: // fire
                    meleeEnemyPrefab = normalGoblin;
                    rangedEnemyPrefab = fireSludge;

                    spider = fireElemental;

                    dragon = bloodDragon;

                    bigSkeleton = bigSkeletonPrefab;

                    strongEnemy = fireDemon;

                    ghostEnemy = ghostEnemyPrefab;
                    break;
                case 70: // violence
                    meleeEnemyPrefab = bloodGoblin;
                    rangedEnemyPrefab = bloodSludge;

                    spider = bloodSpider;

                    dragon = bloodDragon;



                    strongEnemy = bloodSkull;

                    ghostEnemy = ghostEnemy;
                    break;
                case 80: // dark
                    meleeEnemyPrefab = normalGoblin;
                    rangedEnemyPrefab = normalSludge;

                    spider = viperFish;

                    dragon = blackHole;

                    strongEnemy = soulEater;

                    ghostEnemy = wraith;
                    break;
                case 90: // ice
                    meleeEnemyPrefab = normalGoblin;
                    rangedEnemyPrefab = normalSludge;

                    spider = iceElemental;

                    dragon = iceBlock;

                    strongEnemy = yetiDemon;

                    ghostEnemy = normalSludge;
                    break;

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        int roomNo = nextRoomChecker.S.roomNumber;


        setEnemies();

        

        

    }
}
