using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rangedEnemy : MonoBehaviour
{
    public Transform player;

    private float shootingRange = 9f;

    public float chaseSpeed = 3f;
    public float retreatSpeed = 2f;


    public Sprite anim1;
    public Sprite anim2;
    public Sprite anim3;

    public GameObject bulletPrefab;
    

    private float bulletSpeed = 6.5f;
    private float shootingCooldown = 2f;

    private bool isChasing = true;
    private float shootingTimer = 0f;
    private bool isShooting = false;

    public GameObject bullet;

    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        if (selectCharacter.mapSelected == "dungeon")
        {
            if (Time.frameCount % 60 < 12)
            {
                spriteRenderer.sprite = anim1;
            }
            else if (Time.frameCount % 60 < 24)
            {
                spriteRenderer.sprite = anim2;
            }
            else if (Time.frameCount % 60 < 36)
            {
                spriteRenderer.sprite = anim3;
            }
            else if (Time.frameCount % 60 < 48)
            {
                spriteRenderer.sprite = anim2;
            }
            else
            {
                spriteRenderer.sprite = anim1;
            }
        }

        if (distanceToPlayer > shootingRange)
        {
            // Move towards the player
            transform.position = Vector2.MoveTowards(transform.position, player.position, nextRoomChecker.S.enemyMovementSpeed/2 * Time.deltaTime);
        }
        else
        {
            // Move away from the player
            transform.position = Vector2.MoveTowards(transform.position, player.position, -(nextRoomChecker.S.enemyMovementSpeed-1)/2 * Time.deltaTime);
        }

        // Check if it's time to shoot
        if (distanceToPlayer <= shootingRange && !isShooting)
        {
            isShooting = true;
            shootingTimer = shootingCooldown;
            Shoot();
        }

        // Update the shooting cooldown timer
        if (isShooting)
        {
            shootingTimer -= Time.deltaTime;
            if (shootingTimer <= 0f)
            {
                isShooting = false;
            }
        }

    }

    private void Shoot()
    {
        // Instantiate a bullet and set its velocity towards the player

        if (bullet != null)
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
            Vector2 direction = (player.position - transform.position).normalized;
            bulletRigidbody.velocity = direction * bulletSpeed;

            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.Play();
        }
    }

}
