using UnityEngine;
using System;

public class meleeEnemy : MonoBehaviour
{
    public float speed = 3f; // Enemy movement speed
    public int damage = 10; // Amount of damage inflicted on the player
    private Transform player; // Reference to the player's transform

    private float playerHP;


    public Sprite rightSprite;
    public Sprite leftSprite;
    
    public SpriteRenderer spriteRenderer;

    private int randomSpeed;

    public float movementSpeed;

    public bool enemySlowedDown = false;

    public bool Webbed;

    public GameObject healthBar;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;


        spriteRenderer = GetComponent<SpriteRenderer>();

        
        playerHP = hpStorePlayer.S.playerHealth;
        

        if (gameObject.name.Contains("ghost"))
        {
            System.Random random = new System.Random();
            randomSpeed = random.Next(2, 5);
            movementSpeed = randomSpeed;
        }
        else if (gameObject.name.Contains("necromancer") || gameObject.name.Contains("soulEater"))
        {
            movementSpeed = 0.6f;
        }
        else if (gameObject.name.Contains("Goblin"))
        {
            movementSpeed = nextRoomChecker.S.enemyMovementSpeed; 
        }
        else if (gameObject.name.Contains("hound") || gameObject.name.Contains("wasp")) 
        {
            movementSpeed = 5f;
        }
        else if(gameObject.name.Contains("zombieHound"))
        {
            movementSpeed = 3.5f;
        }
        else if (gameObject.name.Contains("caveSpider"))
        {
            movementSpeed = 4f;
        }
        else if (gameObject.name.Contains("gildedHorror"))
        {
            movementSpeed = 6.5f;
        }
        else if (gameObject.name.Contains("voidWraith"))
        {
            System.Random random = new System.Random();
            randomSpeed = random.Next(4, 6);
            movementSpeed = randomSpeed;
        }
        else
        {
            movementSpeed = 2f;
        }



    }


    

private void Update()
    {

        if (hpStorePlayer.S.playerHealth != null)
        {
            playerHP = hpStorePlayer.S.playerHealth;
        }


        if (!Webbed)
        {
            // Calculate the direction towards the player
            Vector3 direction = player.position - transform.position;
            direction.Normalize();

            

            // Move towards the player
            transform.position += direction * movementSpeed * Time.deltaTime;
        }


        if (!gameObject.name.Contains("maggot") && !gameObject.name.Contains("wasp") 
            && !gameObject.name.Contains("spore") && !gameObject.name.Contains("Gangsta") 
            && !gameObject.name.Contains("strongZombie") && !gameObject.name.Contains("caveSpider")
            && !gameObject.name.Contains("fireDemon"))
        {
            if (Time.frameCount % 60 < 30)
            {

                spriteRenderer.sprite = rightSprite;
            }
            else
            {
                spriteRenderer.sprite = leftSprite;
            }
        }
        

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        // Check if the collided object is the player
        if (collision.gameObject.CompareTag("Player"))
        {
            
            // Inflict damage on the player
            
            
            
            if (playerHP != null)
            {
                if (gameObject.name.Contains("ghost"))
                {
                    hpStorePlayer.S.playerHealth -= nextRoomChecker.S.meleeDamage * 2 * playerDamageTakenMultiplierStore.damageMultiplier;
                }
                else if (gameObject.name.Contains("voidWraith"))
                {
                    hpStorePlayer.S.playerHealth -= nextRoomChecker.S.meleeDamage * 3 * playerDamageTakenMultiplierStore.damageMultiplier;
                }
                else
                {
                    hpStorePlayer.S.playerHealth -= nextRoomChecker.S.meleeDamage * playerDamageTakenMultiplierStore.damageMultiplier;
                }
            }
            
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        // Check if the collided object is the player
        if (collision.gameObject.CompareTag("Player") && gameObject.name.Contains("ghost"))
        {

            // Inflict damage on the player
            if (playerHP != null)
            {
                hpStorePlayer.S.playerHealth -= nextRoomChecker.S.meleeDamage * playerDamageTakenMultiplierStore.damageMultiplier;
            }

        }
    }
}