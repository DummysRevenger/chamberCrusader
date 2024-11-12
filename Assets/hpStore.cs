using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpStore : MonoBehaviour
{
    public float health = 200;

    public float maxHealth = 200;

    public GameObject ammo;

    public bool midasTouched;

    public static bool pyramidDown = false;

    public GameObject smallSkeleton;

    public GameObject downAnim;

    private bool alreadyDead = false;

    private GameObject theAnimation;

    public playerMovement playerMovementScript;

    private bloodSkullShoot skullShootScript;

    private GameObject mudManPuddle;

    public GameObject paladinSword;

    public GameObject paladinHurtBox;


    private GameObject gummyBear;
    private GameObject peanutCup;
    private GameObject lollipop;
    private GameObject bonBon;
    private GameObject candyCorn;
    private GameObject candyCane;
    private GameObject liquorice;

    private GameObject halfWyvernLeft;

    private GameObject halfWyvernRight;




    void Awake()
    {
        if (gameObject.name.Contains("the Pyramid"))
        {
            pyramidDown = false;
        }
    }

    

    // Start is called before the first frame update
    void Start()
    {

        if (!gameObject.name.Contains("dragon") && !gameObject.name.Contains("ghost") &&
            !gameObject.name.Contains("Skull") && !gameObject.name.Contains("sporangium") && !gameObject.name.Contains("UFO")
            && !gameObject.name.Contains("voidWraith") && !gameObject.name.Contains("waspHive") && !gameObject.name.Contains("the Plant"))
        {

            enemiesInRoomChecker.S.enemiesInRoomNumber += 1;

            if (pyramidStage4Changer.S.pyramidStage3)
            {
                pyramidStage4Changer.S.enemyCap -= 1;


            }
        }


        if (gameObject.name == "the Pyramid")
        {
            pyramidDown = false;
        }


        if (gameObject.name.Contains("wyvern"))
        {
            halfWyvernLeft = Resources.Load("Scenes/update12Resources/luststorm/halfWyvernLeft") as GameObject;

            halfWyvernRight = Resources.Load("Scenes/update12Resources/luststorm/halfWyvernRight") as GameObject;
        }



        string bonbonPath = "Scenes/update11Resources/newprefabs/candy/bonbon";
        string candyCanePath = "Scenes/update11Resources/newprefabs/candy/candyCane";
        string candyCornPath = "Scenes/update11Resources/newprefabs/candy/candyCorn";
        string liquoricePath = "Scenes/update11Resources/newprefabs/candy/liquorice";
        string lollipopPath = "Scenes/update11Resources/newprefabs/candy/lollipop";
        string peanutCupPath = "Scenes/update11Resources/newprefabs/candy/peanutCup";
        string gummyPath = "Scenes/update11Resources/newprefabs/candy/gummy";


        // find the candies
        gummyBear = Resources.Load(gummyPath) as GameObject;
        candyCorn = Resources.Load(candyCornPath) as GameObject;
        candyCane = Resources.Load(candyCanePath) as GameObject;
        lollipop = Resources.Load(lollipopPath) as GameObject;
        bonBon = Resources.Load(bonbonPath) as GameObject;
        peanutCup = Resources.Load(peanutCupPath) as GameObject;
        liquorice = Resources.Load(liquoricePath) as GameObject;

        mudManPuddle = Resources.Load("Scenes/update12Resources/muddygluttony/mudManPuddle") as GameObject;

        setHealth();


        if (gameObject.name.Contains("UFO"))
        {
            downAnim = GameObject.Find("ufo death_0");
        }

        if (gameObject.name.Contains("the Pyramid"))
        {
            downAnim = GameObject.Find("pyramidDeath_0");

            health = 3000f;
            maxHealth = 3000f;
        }

        if (gameObject.name.Contains("bloodSkull"))
        {
            skullShootScript = GetComponent<bloodSkullShoot>();
        }

        statsStore.enemies++;

        
        
        if(gameObject.name.Contains("anubis"))
        {
            downAnim = GameObject.Find("anubis death anim_0");
        }

        


    }

    void setHealth()
    {

        if (gameObject.name.Contains("fireElemental") || gameObject.name.Contains("Hornet"))
        {
            maxHealth = 480f;
            health = 480f;
        }

        if (gameObject.name.Contains("crocodile") || gameObject.name.Contains("Leviathan"))
        {
            maxHealth = 800;
            health = 800;
        }



        if (gameObject.name.Contains("abyssalHorror"))
        {
            maxHealth = 20000f;
            health = 20000f;





        }

        if (gameObject.name.Contains("yetiDemon"))
        {
            maxHealth = 4000f;
            health = 4000f;
        }

        if (gameObject.name.Contains("fireDemon"))
        {
            maxHealth = 1000f;
            health = 1000f;
        }

        if (gameObject.name.Contains("sporangium") || gameObject.name.Contains("waspHive"))
        {
            // set the defeat animation
            //downAnim = 

            maxHealth = 20;
            health = 20;



        }

        if (gameObject.name.Contains("necromancer"))
        {
            maxHealth = 5000;
            health = 5000;
        }

        if (gameObject.name.Contains("UFO"))
        {
            maxHealth = 100f;
            health = 100f;
        }

        if (gameObject.name.Contains("Goblin"))
        {



            switch (selectCharacter.mapSelected)
            {
                case "dungeon":
                    downAnim = GameObject.Find("goblindeathanim150_0");
                    break;

                case "blood":
                    downAnim = GameObject.Find("bloodgoblinspritesheet_0");
                    break;

                case "desert":
                    downAnim = GameObject.Find("cactus goblin death anim_0");
                    break;
            }

            health = nextRoomChecker.S.enemyHealth;
            maxHealth = nextRoomChecker.S.enemyHealth;
        }
        else if (gameObject.name.Contains("Frog"))
        {
            health = 600f;
            maxHealth = 600f;
        }
        else if (gameObject.name.Contains("sentry"))
        {

            switch (selectCharacter.mapSelected)
            {
                case "dungeon":
                    downAnim = GameObject.Find("spider death_0");
                    break;

                case "blood":
                    downAnim = GameObject.Find("blood spider death_0");
                    break;

                case "desert":
                    downAnim = GameObject.Find("scorpion defeat 1_0");
                    break;
            }


            health = nextRoomChecker.S.enemyHealth * 2.5f;
            maxHealth = nextRoomChecker.S.enemyHealth * 2.5f;

        }
        else if (gameObject.name.Contains("bigSkeleton"))
        {

            downAnim = GameObject.Find("skeleton death_0");

            health = nextRoomChecker.S.enemyHealth * 2f;
            maxHealth = nextRoomChecker.S.enemyHealth * 2f;
        }

        else if (gameObject.name.Contains("smallSkeleton"))
        {

            downAnim = GameObject.Find("smallskeletondeath");

            health = nextRoomChecker.S.enemyHealth * 1.5f;
            maxHealth = nextRoomChecker.S.enemyHealth * 1.5f;

        }

        else if (gameObject.name.Contains("trapPlant") || gameObject.name.Contains("halfWyvern"))
        {
            health = nextRoomChecker.S.enemyHealth * 3f;
            maxHealth = nextRoomChecker.S.enemyHealth * 3f;


        }




        else if (gameObject.name.Contains("spore"))
        {
            health = nextRoomChecker.S.enemyHealth * 0.5f;
            maxHealth = nextRoomChecker.S.enemyHealth * 0.5f;

        }

        else if (gameObject.name.Contains("zombieHound"))
        {
            health = nextRoomChecker.S.enemyHealth * 2f;
            maxHealth = nextRoomChecker.S.enemyHealth * 2f;
        }

        else if (gameObject.name.Contains("ranged"))
        {
            health = nextRoomChecker.S.enemyHealth / 2;
            maxHealth = nextRoomChecker.S.enemyHealth / 2;

            switch (selectCharacter.mapSelected)
            {
                case "dungeon":
                    downAnim = GameObject.Find("rangedenemydefeat_0");
                    break;

                case "blood":
                    downAnim = GameObject.Find("blood sludge sprite sheet_0");
                    break;

                case "desert":
                    downAnim = GameObject.Find("sandsludgedeathanim_0");
                    break;
            }


        }
        else if (gameObject.name == "gildedHorror")
        {
            health = 777f;

            maxHealth = 777f;
        }
        else if (gameObject.name == "soulEater")
        {
            health = 500f;

            maxHealth = 500f;
        }
        else if (gameObject.name == "wyvern")
        {
            health = 999f;

            maxHealth = 999f;




        }
        else if (gameObject.name.Contains("dragon") || gameObject.name.Contains("ghost")
            || gameObject.name.Contains("bloodSkull") || gameObject.name.Contains("thePlant")
            || gameObject.name.Contains("voidWraith"))
        {
            health = 99999f;



            if (gameObject.name.Contains("dragon"))
            {
                switch (selectCharacter.mapSelected)
                {
                    case "dungeon":
                        downAnim = GameObject.Find("ghost dragon death sprite sheet_0");
                        break;

                    case "blood":
                        downAnim = GameObject.Find("blood dragon sprite sheet death_0");
                        break;

                    case "desert":
                        downAnim = GameObject.Find("bestdragondeathanimation_0");
                        break;
                }
            }
            else if (gameObject.name.Contains("ghost"))
            {
                downAnim = GameObject.Find("ghost death_0");
            }
            else if (gameObject.name.Contains("bloodSkull"))
            {
                downAnim = GameObject.Find("BLOOD SKULL DEATH ANIM_0");
            }

        }


        if (gameObject.name.Contains("Snake"))
        {


            downAnim = GameObject.Find("snake head death_0");


            health = 1750;

            maxHealth = 1750;
        }



        if (gameObject.name.Contains("crawlingSnake"))
        {
            downAnim = null;


            health = 500;

            maxHealth = 500;
        }
    }

    public IEnumerator getDestroyed()
    {

        if (GetComponent<BoxCollider2D>() != false)
        {
            GetComponent<BoxCollider2D>().enabled = false;
        }

        
        if (gameObject.name.Contains("viperFish"))
        {
            viperfishDartAtPlayer attackScript = GetComponent<viperfishDartAtPlayer>();

            attackScript.CancelInvoke();

            Destroy(attackScript.actualAttackObject);


        }

        if (gameObject.name.Contains("abyssalHorror"))
        {
            Destroy(GetComponent<spawnAbyssalLaser>().theLaser);

            GetComponent<spawnAbyssalLaser>().CancelInvoke("createLaser");

        }


        GetComponent<SpriteRenderer>().enabled = false;

        if (!gameObject.name.Contains("dragon") || !gameObject.name.Contains("Skull"))
        {
            if (GetComponent<Rigidbody2D>() != null)
            {
                GetComponent<Rigidbody2D>().isKinematic = true;
            }
        }

        if (downAnim != null)
        {
                theAnimation = Instantiate(downAnim, transform.position, Quaternion.identity);
        }


        if (gameObject.name.Contains("ranged"))
        {
            GetComponent<rangedEnemy>().enabled = false;
        }
        else if(gameObject.name.Contains("bigSkeleton"))
        {
            GetComponent<meleeEnemy>().enabled = false;
        }

        



        if (gameObject.name.Contains("Snake"))
        {
            GetComponent<OrbitPlayer>().enabled = false;
            GetComponent<snakeBiteAttack>().enabled = false;
        }

        
        yield return new WaitForSeconds(2f);



        if (!gameObject.name.Contains("the Pyramid"))
        {
            Destroy(theAnimation);
        }

        Destroy(gameObject);

    }

    IEnumerator spawnSmallSkeletons()
    {

        yield return new WaitForSeconds(1f);

        Instantiate(smallSkeleton, transform.position, Quaternion.identity);
        Instantiate(smallSkeleton, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {




        if (enemiesInRoomChecker.S.enemiesInRoomNumber <= 0 &&
            (gameObject.name.Contains("Skull") || gameObject.name.Contains("dragon") 
            || gameObject.name.Contains("ghost") || gameObject.name.Contains("thePlant")
            || gameObject.name.Contains("voidWraith") || gameObject.name.Contains("waspHive")))
        {
            health = 0;
        }



        if (health <= 0 && !alreadyDead)  // if dead and not any invincible enemy
        {

            if (gameObject.name.Contains("sentry"))
            {
                GetComponent<spiderEnemy>().CancelInvoke("Shoot");
            }

            if (gameObject.name.Contains("Hornet"))
            {
                GetComponent<enemyHornetAttackPlayer>().CancelInvoke("attack");


                Debug.Log("wtf bro stinger");
            }

            if (gameObject.name.Contains("Frog"))
            {
                GetComponent<frogAttack>().CancelInvoke("startAttack");
            }



            if (gameObject.name.Contains("the Pyramid"))
            {
                enemiesInRoomChecker.S.enemiesInRoomNumber = 0;

                pyramidDown = true;
            }

            if (!(gameObject.name.Contains("Skull") || gameObject.name.Contains("UFO") || gameObject.name.Contains("waspHive")
                || gameObject.name.Contains("dragon") || gameObject.name.Contains("ghost") ||
                gameObject.name.Contains("thePlant") || gameObject.name.Contains("the Pyramid") || gameObject.name.Contains("voidWraith")))
            {
                enemiesInRoomChecker.S.enemiesInRoomNumber--;
            }


            if (gameObject.name.Contains("sludgeElemental") || gameObject.name.Contains("mudMan"))
            {
                gameObject.GetComponent<throwMudAtPlayer>().CancelInvoke("throwMud");
            }


            if (gameObject.name.Contains("worm") || gameObject.name.Contains("Leviathan"))
            {


                GetComponent<jumpAtPlayer>().CancelInvoke("warn");

                GetComponent<jumpAtPlayer>().CancelInvoke("disappear");


                Debug.Log("wtf bro");

                if (GetComponent<jumpAtPlayer>().theWarning != null)
                {
                    GetComponent<jumpAtPlayer>().deleteWarning();
                }

                

            }

            if (gameObject.name.Contains("trapPlant"))
            {

                if (GetComponent<appearAtPlayer>().theWarning != null)
                {
                    GetComponent<appearAtPlayer>().deleteWarning();
                }


                GetComponent<appearAtPlayer>().CancelInvoke("warn");
            }


            gameObject.tag = "Untagged";


            if (midasTouched)
            {
                // sprite turns gold and eventually disappears
                // ignores normal death animation
            }


            if (gameObject.name == "sludgeElemental")
            {
                GetComponent<throwMudAtPlayer>().CancelInvoke();
            }


            if (gameObject.name == "fireDemon2")
            {
                GetComponent<strongZombieAttack>().CancelInvoke();
            }

            if (gameObject.name == "mudMan")
            {
                Instantiate(mudManPuddle, transform.position, transform.rotation);

                GetComponent<throwMudAtPlayer>().CancelInvoke();
            }

            if (gameObject.name == "wyvern")
            {
                Instantiate(halfWyvernRight, transform.position, transform.rotation);
                Instantiate(halfWyvernLeft, transform.position, transform.rotation);
            }

            if (gameObject.name.Contains("strongZombie"))
            {
                GetComponent<strongZombieAttack>().CancelInvoke();
            }


            if (gameObject.name.Contains("crocodile") || gameObject.name.Contains("giantFrog"))
            {
                GetComponent<frogAttack>().CancelInvoke();
            }

            

            // drop candy
            if (selectCharacter.characterSelected == "bunny" && !gameObject.name.Contains("smallSkeleton"))
            {
                System.Random random = new System.Random();

                int randomNum = Random.Range(0, 100);

                if (randomNum >= 39) // don't drop liquorice
                {
                    if (randomNum <= 59)
                    {
                        Instantiate(lollipop, transform.position, transform.rotation);
                    }
                    else
                    {
                        if (randomNum <= 79)
                        {
                            Instantiate(bonBon, transform.position, transform.rotation);
                        }
                        else
                        {
                            if (randomNum <= 84)
                            {
                                Instantiate(candyCane, transform.position, transform.rotation);
                            }
                            else
                            {
                                if (randomNum <= 89)
                                {
                                    Instantiate(candyCorn, transform.position, transform.rotation);
                                }
                                else
                                {
                                    if (randomNum <= 94)
                                    {
                                        Instantiate(peanutCup, transform.position, transform.rotation);
                                    }
                                    else
                                    {
                                        if (randomNum > 98)
                                        {
                                            Instantiate(gummyBear, transform.position, transform.rotation);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    Instantiate(liquorice, transform.position, transform.rotation);
                }

            }




            if (skullShootScript != null)
            {
                skullShootScript.CancelInvoke();
                skullShootScript.enabled = false;
            }

            if (gameObject.name.Contains("UFO"))
            {
                UFONumberStore.S.UFONumber--;
            }

            if (gameObject.name.Contains("thrombus"))
            {
                switch (selectCharacter.characterSelected)
                {
                    case "bunny":
                        playerMovementSpeedStore.S.speed = 5f;
                        break;
                    case "knight":
                    case "pride":
                    case "envy":
                        playerMovementSpeedStore.S.speed = 4f;
                        break;
                    case "sloth":
                        playerMovementSpeedStore.S.speed = 2.5f;
                        break;
                    case "gluttony":
                        playerMovementSpeedStore.S.speed = 3f;
                        break;

                    case "ninja":
                    case "greed":
                    case "lust":
                        playerMovementSpeedStore.S.speed = 7f;
                        break;

                    case "soldier":
                    case "wrath":
                        playerMovementSpeedStore.S.speed = 6f;
                        break;
                    case "shop":
                        playerMovementSpeedStore.S.speed = 5f;
                        break;

                }
            }

            if (GetComponent<paladinShoot>() != null)
            {
                paladinShoot shootScript = GetComponent<paladinShoot>();

                Destroy(paladinSword);

                Destroy(paladinHurtBox);

                shootScript.CancelInvoke();
            }

            statsStore.kills++;

            if (!gameObject.name.Contains("sentry") || !gameObject.name.Contains("dragon"))
            {
                pointsStore.S.points = pointsStore.S.points + 100 + (nextRoomChecker.S.roomNumber - 1) * 50;

                statsStore.points = statsStore.points + 300 + (nextRoomChecker.S.roomNumber - 1) * 50;

                
            }
            else
            {
                pointsStore.S.points = pointsStore.S.points + 300 + (nextRoomChecker.S.roomNumber - 1) * 50;

                statsStore.points = statsStore.points +  300 + (nextRoomChecker.S.roomNumber - 1) * 50;


            }

            if (gameObject.name.Contains("bigSkeleton"))
            {
                pointsStore.S.points = pointsStore.S.points + 150 + (nextRoomChecker.S.roomNumber - 1) * 50;

                statsStore.points = statsStore.points + 150 + (nextRoomChecker.S.roomNumber - 1) * 50;

                StartCoroutine(spawnSmallSkeletons());



            }

            if (gameObject.name.Contains("UFO") && selectCharacter.characterSelected != "bunny")
            {
                Instantiate(ammo, transform.position, Quaternion.identity);
            }

            if (gameObject.name.Contains("necromancerOfTheMarsh"))
            {
                necromancerObjectsStore.S.necromancerBackground.SetActive(false);

                necromancerObjectsStore.S.globalLight.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity = 0.75f;

                necromancerObjectsStore.S.spotLight.SetActive(false);
            }


            if ((gameObject.name.Contains("ranged") || gameObject.name.Contains("sentry")) && selectCharacter.characterSelected != "bunny")
            {
                System.Random random = new System.Random();

                int randomNum = random.Next(0, 5);

                
                switch (randomNum)
                {
                    case 0:
                        Instantiate(ammo, transform.position, Quaternion.identity);
                        
                        break;
                    case 1:
                        
                        break;
                    case 2:
                        break;
                    case 3:
                        Instantiate(ammo, transform.position, Quaternion.identity); 
                        break;
                    case 4:

                        
                        
                            Instantiate(ammo, transform.position, Quaternion.identity);
                            Instantiate(ammo, transform.position, Quaternion.identity);
                        
                        break;
                }


                


            }



            
                StartCoroutine(getDestroyed());
            

            alreadyDead = true;
        }
    }
}
