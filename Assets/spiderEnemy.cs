using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiderEnemy : MonoBehaviour
{
    

    private float shootingRange = 20f;

    public float chaseSpeed = 3f;
    public float retreatSpeed = 2f;


    

    public GameObject bulletPrefab;


    private float bulletSpeed = 5f;
    private float shootingCooldown = 2f;

    private bool isChasing = true;
    private float shootingTimer = 0f;
    private bool isShooting = false;

    public GameObject bullet;

    private SpriteRenderer spriteRenderer;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {

        float distanceToPlayer = Vector2.Distance(transform.position, player.transform.position);

        

        // Check if it's time to shoot
        if (distanceToPlayer <= shootingRange && !isShooting)
        {
            isShooting = true;
            shootingTimer = shootingCooldown;
            Shoot();
        }

        //Update the shooting cooldown timer
        if (isShooting)
        {
            shootingTimer -= Time.deltaTime;
            if (shootingTimer <= 0f)
            {
                isShooting = false;
            }
        }

    }

    

    public void Shoot()
    {
        
        // Calculate the angles for eight directions
        float angleStep = 45f;
        for (int i = 0; i < 8; i++)
        {
            float angle = i * angleStep;

            // Calculate the direction vector based on the angle
            Vector2 direction = Quaternion.Euler(0f, 0f, angle) * Vector2.right;

            // Instantiate a bullet prefab
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);

            // Set the bullet's velocity based on the direction and speed
            Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();

            bulletRigidbody.velocity = direction * bulletSpeed;


            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.Play();
        }
    }

}
