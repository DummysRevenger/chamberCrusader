using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpStore : MonoBehaviour
{
    public float health = 200;

    public GameObject ammo;

    public GameObject smallSkeleton;

    public GameObject downAnim;

    private bool alreadyDead = false;

    // Start is called before the first frame update
    void Start()
    {

        if (!gameObject.name.Contains("dragon"))
        {
            enemiesInRoomChecker.S.enemiesInRoomNumber++;
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
        }
        else if(gameObject.name.Contains("sentry"))
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
            
        }
        else if(gameObject.name.Contains("bigSkeleton"))
        {

            downAnim = GameObject.Find("skeleton death_0");

            health = nextRoomChecker.S.enemyHealth * 3f;
        }

        else if (gameObject.name.Contains("smallSkeleton"))
        {

            downAnim = GameObject.Find("smallskeletondeath");

            health = nextRoomChecker.S.enemyHealth * 1.5f;
            
        }
        else if (gameObject.name.Contains("ranged"))
        {
            health = nextRoomChecker.S.enemyHealth/2;

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
        else if (gameObject.name.Contains("dragon"))
        {
            health = 99999f;

            

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

    }

    public IEnumerator getDestroyed()
    {

        GetComponent<BoxCollider2D>().enabled = false;

        GetComponent<SpriteRenderer>().enabled = false;

        GetComponent<Rigidbody2D>().isKinematic = true;

        GameObject theAnimation = Instantiate(downAnim, transform.position, Quaternion.identity);

        if (gameObject.name.Contains("ranged"))
        {
            GetComponent<rangedEnemy>().enabled = false;
        }
        else if(gameObject.name.Contains("bigSkeleton"))
        {
            GetComponent<meleeEnemy>().enabled = false;
            
            

            
        }


        yield return new WaitForSeconds(1.1f);
        
        Destroy(theAnimation);

        if (!gameObject.name.Contains("dragon"))
        {


            enemiesInRoomChecker.S.enemiesInRoomNumber -= 1;
        }

        Destroy(gameObject);

    }

    IEnumerator spawnSmallSkeletons()
    {

        yield return new WaitForSeconds(1f);

        Instantiate(smallSkeleton, transform.position, Quaternion.identity);
        Instantiate(smallSkeleton, transform.position, Quaternion.identity);
        Instantiate(smallSkeleton, transform.position, Quaternion.identity);
        Instantiate(smallSkeleton, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

        if (enemiesInRoomChecker.S.enemiesInRoomNumber <= 0 && gameObject.name.Contains("dragon"))
        {
            health = 0;
        }


        if (health <= 0 && !alreadyDead)
        {
            

            if (!gameObject.name.Contains("sentry") || !gameObject.name.Contains("dragon"))
            {
                pointsStore.S.points = pointsStore.S.points + 100 + (nextRoomChecker.S.roomNumber - 1) * 50;
            }
            else
            {
                pointsStore.S.points = pointsStore.S.points + 300 + (nextRoomChecker.S.roomNumber - 1) * 50;
            }
            
            if (gameObject.name.Contains("bigSkeleton"))
            {
                pointsStore.S.points = pointsStore.S.points + 150 + (nextRoomChecker.S.roomNumber - 1) * 50;


                StartCoroutine(spawnSmallSkeletons());
                


            }



            if (gameObject.name.Contains("ranged") || gameObject.name.Contains("sentry"))
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
