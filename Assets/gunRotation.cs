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

    public GameObject playerBullet;

    public GameObject playerRocket;

    private float spreadAngle = 0.1f;

    public GameObject gun;

    void Start()
    {
        S = this;
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
        }
        else if (playerSwitcher.S.playerType == "ninja")
        {
            
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
            bulletRigidbody.velocity = 12f * aimDirection;

            

        }



            AudioSource audioSource = GetComponent<AudioSource>();
            
            audioSource.Play();

    }

   


    void FixedUpdate()
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


        


        if (Input.GetMouseButtonDown(0) && ammoStore.S.playerAmmo > 0)
        {
            

            if (playerSwitcher.S.playerType == "knight")
            {
                Shoot();
                statsStore.shotsFired++;
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

                    statsStore.shotsFired++;

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
        }









    }


}