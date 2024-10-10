using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class envyStealAttackAbility : MonoBehaviour
{

    // dungeon blob
    public GameObject playerBullet;

    public static envyStealAttackAbility S;

    public bool extraCash;

    private SpriteRenderer theRenderer;

    public GameObject cross2;

    private bool abilityRunning;

    private bool isCooldown;

    private float cooldownTimer = 0.0f;

    public bool crocodileAbility;

    public string projectileStolen;


    public bool contactAbilityRunning = false;

    public AudioSource audioSource;

    


    // Start is called before the first frame update
    void Start()
    {

        S = this;


        audioSource = GetComponent<AudioSource>();

        theRenderer = GetComponent<SpriteRenderer>();

        
    }

    

    

    GameObject GetClosestObject()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag("enemy");
        GameObject closest = null;
        float closestDistance = 30;

        foreach (GameObject target in targets)
        {
            float distance = Vector3.Distance(transform.position, target.transform.position);
            if (distance < closestDistance)
            {
                closestDistance = distance;
                closest = target;
            }
        }

        return closest;
    }

    void shootBullet()
    {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, transform.position.z - Camera.main.transform.position.z));

        Vector3 aimDirection = (worldMousePosition - transform.position).normalized;


        GameObject bullet = Instantiate(playerBullet, transform.position, Quaternion.identity);
        Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
        bulletRigidbody.velocity = 10f * aimDirection;
    }

        

    // Update is called once per frame
    void Update()
    {

        if (crocodileAbility)
        {

            playerDamageTakenMultiplierStore.damageMultiplier = 0.75f;

            playerMovementSpeedStore.S.speed = 5;


        }

        if (!isCooldown && (Input.GetKeyDown(KeyCode.G) || Input.GetKeyDown(KeyCode.F)))
        {


            audioSource.clip = playerAudioStore.S.audioClips[3];
            audioSource.Play(); // Play the clip


            GameObject closestObject = GetClosestObject();

            if (closestObject != null)
            {
                

                if (closestObject.gameObject.name.Contains("ranged")) // every world
                {
                    projectileStolen = "normalBullet";

                    shootBullet();
                    Invoke("shootBullet", 0.5f);
                    Invoke("shootBullet", 1f);
                    Invoke("shootBullet", 1.5f);
                    Invoke("shootBullet", 2f);
                    Invoke("shootBullet", 2.5f);
                    Invoke("shootBullet", 3f);
                    Invoke("shootBullet", 3.5f);
                }
                else if (closestObject.gameObject.name.Contains("goblin")) // every world
                {

                    projectileStolen = "coin";

                    playerMovementSpeedStore.S.speed = 7;

                    extraCash = true;

                }
                else if (closestObject.gameObject.name.Contains("Dragon")) // not retribution
                {
                    projectileStolen = "ghostBulletExtra";

                    GetComponent<BoxCollider2D>().enabled = false;

                    contactAbilityRunning = true;


                }
                else if (closestObject.gameObject.name.Contains("ghost"))
                { // not retribution

                    projectileStolen = "ghostBullet";

                    GetComponent<BoxCollider2D>().enabled = false;
                }
                else if (closestObject.gameObject.name.Contains("caveSpider"))
                { // caves
                    projectileStolen = "webBall";

                    playerMovementSpeedStore.S.speed = 6;
                }
                else if (closestObject.gameObject.name.Contains("giantFrog"))
                { // swamp
                    projectileStolen = "flyBullet";

                    playerMovementSpeedStore.S.speed = 6;
                }
                else if (closestObject.gameObject.name.Contains("crocodile"))
                { // swamp
                    projectileStolen = "crocodileChompBullet";

                    crocodileAbility = true;

                }
                else if (closestObject.gameObject.name.Contains("yeti"))
                { // ice
                    projectileStolen = "snowBall";
                    // attacks freeze/slow down enemies
                }
                else if (closestObject.gameObject.name.Contains("soulEater"))
                { // dark fraud
                    projectileStolen = "vampireBullet";
                    
                }
                else if (closestObject.gameObject.name.Contains("paladin"))
                { // dungeon
                    projectileStolen = "superBullet";
                }
                else
                {
                    projectileStolen = "superBullet";
                }
                
            }


            
            

            

            cross2.SetActive(true);

            abilityRunning = true;


            cooldownTimer = 10f;

            isCooldown = true;

            Invoke("endAbility", 5f);



        }

        if (isCooldown)
        {

            if (enemiesInRoomChecker.S.enemiesInRoomNumber > 0)
            {
                cooldownTimer -= Time.deltaTime;
            }

            if (cooldownTimer <= 0.0f)
            {
                // Cooldown is over
                isCooldown = false;

                cross2.SetActive(false);

            }
        }


    }
}
