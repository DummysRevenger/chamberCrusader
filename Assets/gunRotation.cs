using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunRotation : MonoBehaviour
{
    private Vector3 rotationAxis = Vector3.forward;

    public static gunRotation S;

    private Vector3 aimDirection; 

    private Rigidbody2D bulletRigidbody;
    private Rigidbody2D rocketRigidbody;

    private Rigidbody2D bulletRigidbody1;
    private Rigidbody2D bulletRigidbody2;
    private Rigidbody2D bulletRigidbody3;

    private GameObject bullet1;
    private GameObject bullet2;
    private GameObject bullet3;

    public bool shotGunOnCooldown = false;

    public bool RPGOnCoolDown = false;

    public bool KitchenKnifeCoolDown = false;

    public bool coinGunOnCoolDown = false;

    public bool gluttonyForkCoolDown = false;

    public GameObject playerBullet;

    public GameObject playerCoinBulletSmall;

    public GameObject playerCoinBulletBig;

    public GameObject playerRocket;

    private float spreadAngle = 0.1f;

    

    private GameObject player;

    public GameObject gun;

    // envy projectiles
    public GameObject superBullet;

    public GameObject ghostBullet;

    public GameObject ghostBulletEX;

    public GameObject webBall;

    public GameObject snowBall;

    public GameObject flyBullet;

    public GameObject crocodileChompBullet;

    public GameObject vampireBullet;

    private bool flyBallOnCooldown;

    public GameObject envyBullet;

    public GameObject greedArrow;

    public bool greedOnCooldown;

    //cooldown time variables

    public float greedCooldown = 1.5f;

    /*public float flyBulletTime;

    public float rpgCoolTime;

    public float coinGunCoolTime;

    public float shotGunCoolTime;

    public float kitchenKnifeCoolTime;*/



    void Start()
    {
        S = this;

        player = GameObject.FindGameObjectWithTag("Player");
    }

    void flyBallCooldowner()
    {
        flyBallOnCooldown = false;
    }

    void Shoot()
    {
        
        Vector3 mousePosition = Input.mousePosition;
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, transform.position.z - Camera.main.transform.position.z));

        aimDirection = (worldMousePosition - transform.position).normalized;

        

        if (playerSwitcher.S.playerType == "knight")
        {
            GameObject bullet = Instantiate(playerBullet, gun.transform.position, Quaternion.identity);
            bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
            bulletRigidbody.velocity = 10f * aimDirection;

            // use a for loop for each extra barrel
            for (int i = 1; i < barrelCountStore.barrelCount; i++)
            {
                GameObject bullet2 = Instantiate(playerBullet, gun.transform.position, Quaternion.identity);
                bulletRigidbody2 = bullet2.GetComponent<Rigidbody2D>();
                bulletRigidbody2.velocity = 10f * aimDirection;
            }

        }
        else if (playerSwitcher.S.playerType == "ninja")
        {
            

            // use a for loop for each extra barrel


            float randomAngle = Random.Range(-spreadAngle, spreadAngle);

            Vector3 spreadRotation = new Vector3(Mathf.Abs(randomAngle), randomAngle, 0f);

             bullet1 = Instantiate(playerBullet, gun.transform.position, Quaternion.identity);
             bullet2 = Instantiate(playerBullet, gun.transform.position, Quaternion.identity);
             bullet3 = Instantiate(playerBullet, gun.transform.position, Quaternion.identity);

            bulletRigidbody1 = bullet1.GetComponent<Rigidbody2D>();
            bulletRigidbody2 = bullet2.GetComponent<Rigidbody2D>();
            bulletRigidbody3 = bullet3.GetComponent<Rigidbody2D>();


            
            


            bulletRigidbody1.velocity = 10f * (aimDirection + spreadRotation).normalized;

            randomAngle = Random.Range(-spreadAngle, spreadAngle);
            spreadRotation = new Vector3(Mathf.Abs(randomAngle), randomAngle, 0f);

            aimDirection = aimDirection + spreadRotation;
            bulletRigidbody2.velocity = 10f * (aimDirection + spreadRotation).normalized;

            randomAngle = Random.Range(-spreadAngle, spreadAngle);
            spreadRotation = new Vector3(Mathf.Abs(randomAngle), randomAngle, 0f);

            aimDirection = aimDirection + spreadRotation;

            bulletRigidbody3.velocity = 10f * (aimDirection + spreadRotation).normalized;


            for (int i = 1; i < barrelCountStore.barrelCount; i++)
            {
                GameObject bullet4 = Instantiate(playerBullet, gun.transform.position, Quaternion.identity);
                Rigidbody2D bulletRigidbody4 = bullet4.GetComponent<Rigidbody2D>();
                randomAngle = Random.Range(-spreadAngle, spreadAngle);
                spreadRotation = new Vector3(Mathf.Abs(randomAngle), randomAngle, 0f);
                bulletRigidbody4.velocity = 10f * (aimDirection + spreadRotation).normalized;
            }


        }
        else if (playerSwitcher.S.playerType == "soldier")
        {

            GameObject rocket = Instantiate(playerRocket, gun.transform.position, gun.transform.rotation);
            rocketRigidbody = rocket.GetComponent<Rigidbody2D>();
            rocketRigidbody.velocity = 18f * aimDirection;

        }
        else if (playerSwitcher.S.playerType == "bunny")
        {

            GameObject bullet = Instantiate(playerBullet, gun.transform.position, gun.transform.rotation);
            bulletRigidbody = bullet.GetComponent<Rigidbody2D>();

            if (!rampageAbility.S.abilityRunning)
            {
                bulletRigidbody.velocity = 12f * aimDirection;
            }
            else
            {
                bulletRigidbody.velocity = 36f * aimDirection;
            }

            

        }
        else if (playerSwitcher.S.playerType == "shop")
        {

            

            if (coinCounterStore.roundCoinNumber >= 20)
            {

                coinCounterStore.roundCoinNumber -= 20;

                int coinChoice = Random.Range(0, 4);



                if (coinChoice < 3)

                {
                    GameObject bullet = Instantiate(playerCoinBulletSmall, gun.transform.position, gun.transform.rotation);
                    bulletRigidbody = bullet.GetComponent<Rigidbody2D>();

                    bulletRigidbody.velocity = 12f * aimDirection;
                }
                else
                {
                    GameObject bullet = Instantiate(playerCoinBulletBig, gun.transform.position, gun.transform.rotation);
                    bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
                    bulletRigidbody.velocity = 18f * aimDirection;
                }

            }
            
            
        }
        else if (playerSwitcher.S.playerType == "gluttony")
        {
            GameObject bullet = Instantiate(playerBullet, gun.transform.position, gun.transform.rotation);
            bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
            bulletRigidbody.velocity = 8f * aimDirection;

            Debug.Log("fdhgufdg");
        }
        else if (playerSwitcher.S.playerType == "envy")
        {
            GameObject bullet;
            
            switch(envyStealAttackAbility.S.projectileStolen)
            {
                case "normalBullet":
                    bullet = Instantiate(playerBullet, gun.transform.position, Quaternion.identity);
                    bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
                    bulletRigidbody.velocity = 8f * aimDirection;
                    break;
                case "coin":
                    bullet = Instantiate(playerCoinBulletSmall, gun.transform.position, Quaternion.identity);
                    bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
                    bulletRigidbody.velocity = 10f * aimDirection;
                    break;
                case "ghostBullet":
                    bullet = Instantiate(ghostBullet, gun.transform.position, Quaternion.identity);
                    bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
                    bulletRigidbody.velocity = 12f * aimDirection;
                    break;
                case "ghostBulletExtra":
                    bullet = Instantiate(ghostBulletEX, gun.transform.position, Quaternion.identity);
                    bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
                    bulletRigidbody.velocity = 15f * aimDirection;
                    break;
                case "webBall":

                    
                        bullet = Instantiate(webBall, gun.transform.position, Quaternion.identity);
                        bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
                        bulletRigidbody.velocity = 10f * aimDirection;
                    
                    break;
                case "snowBall":
                     bullet = Instantiate(snowBall, gun.transform.position, Quaternion.identity);
                    bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
                    bulletRigidbody.velocity = 8f * aimDirection;
                    break;
                case "flyBullet":

                    if (!flyBallOnCooldown)
                    {
                        bullet = Instantiate(flyBullet, gun.transform.position, Quaternion.identity);
                        bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
                        bulletRigidbody.velocity = 15f * aimDirection;

                        flyBallOnCooldown = true;

                        Invoke("flyBallCooldowner", 0.5f);
                    }
                    break;
                case "crocodileChompBullet":
                     bullet = Instantiate(crocodileChompBullet, gun.transform.position, Quaternion.identity);
                    bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
                    bulletRigidbody.velocity = 4f * aimDirection;
                    break;
                case "vampireBullet":
                     bullet = Instantiate(vampireBullet, gun.transform.position, Quaternion.identity);
                    bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
                    bulletRigidbody.velocity = 8f * aimDirection;
                    break;
                case "superBullet":
                     bullet = Instantiate(superBullet, gun.transform.position, Quaternion.identity);
                    bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
                    bulletRigidbody.velocity = 17f * aimDirection;
                    break;
                default:
                    bullet = Instantiate(envyBullet, gun.transform.position, Quaternion.identity);
                    bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
                    bulletRigidbody.velocity = 6f * aimDirection;
                    break;
                

            }
           
            
                

                

            }
        else if (playerSwitcher.S.playerType == "greed")
        {

            

            GameObject bullet = Instantiate(greedArrow, gun.transform.position, transform.rotation);
            bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
            bulletRigidbody.velocity = 16f * aimDirection;

            if (player.GetComponent<hpStorePlayer>().playerHealth > 200)
            {
                player.GetComponent<hpStorePlayer>().playerHealth -= 50;
            }
        }
        


            

            AudioSource audioSource = GetComponent<AudioSource>();
            
            audioSource.Play();

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

    void gluttonyForkCooldowner()
    {
        gluttonyForkCoolDown = false;
    }

    void greedCooldowner()
    {
        greedOnCooldown = false;
    }

    void Update()
    {


        


        // Get the mouse position in screen space
        Vector3 mousePosition = Input.mousePosition;

        // Convert the mouse position to world space
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, transform.position.z - Camera.main.transform.position.z));

        // Calculate the direction vector from the sprite to the mouse position
        Vector3 direction = worldMousePosition - transform.position;

        // Calculate the angle in degrees
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Apply the rotation to the sprite
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);


        
        if (Input.GetMouseButton(0))
        {
            if (playerSwitcher.S.playerType == "shop")
            {
                if (!coinGunOnCoolDown)
                {
                    Shoot();

                    coinGunCooldowner.S.StartCoroutineFromOutside();
                }
            }
        }

        if (Input.GetMouseButtonDown(0) && ammoStore.S.playerAmmo > 0)
        {

            statsStore.shotsFired++;

            if (playerSwitcher.S.playerType == "knight")
            {
                Shoot();
                
                ammoStore.S.playerAmmo--;
            }
            else if (playerSwitcher.S.playerType == "ninja")
            {
                if (!shotGunOnCooldown)
                {
                    Shoot();

                    statsStore.shotsFired += 3;

                    shotGunCooldowner.S.StartCoroutineFromOutside();

                    ammoStore.S.playerAmmo--;
                }
            }
            else if (playerSwitcher.S.playerType == "soldier")
            {
                if (!RPGOnCoolDown)
                {
                    Shoot();

                    

                    RPGCooldowner.S.StartCoroutineFromOutside();

                    ammoStore.S.playerAmmo--;
                }
            }
            else if (playerSwitcher.S.playerType == "bunny")
            {
                

                if (!KitchenKnifeCoolDown)
                {
                    Shoot();



                    KitchenKnifeCooldowner.S.StartCoroutineFromOutside();

                }
            }
            else if (playerSwitcher.S.playerType == "gluttony")
            {
                if (!gluttonyForkCoolDown)
                {
                    Shoot();

                    gluttonyForkCoolDown = true;

                    Invoke("gluttonyForkCooldowner", 1f);

                }
            }
            else if (playerSwitcher.S.playerType == "envy")
            {

                if (!flyBallOnCooldown)
                {
                    Shoot();
                }

            }
            else if (playerSwitcher.S.playerType == "greed")
            {
                if (!greedOnCooldown)
                {
                    Shoot();
                    greedOnCooldown = true;


                    Invoke("greedCooldowner", greedCooldown);
                }
            }
            
        }









    }


}