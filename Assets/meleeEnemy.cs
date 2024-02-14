using UnityEngine;

public class meleeEnemy : MonoBehaviour
{
    public float speed = 3f; // Enemy movement speed
    public int damage = 10; // Amount of damage inflicted on the player
    private Transform player; // Reference to the player's transform

    private float playerHP;


    public Sprite rightSprite;
    public Sprite leftSprite;
    
    public SpriteRenderer spriteRenderer;

    private void Start()
    {
         player = GameObject.FindGameObjectWithTag("Player").transform;
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerHP = hpStorePlayer.S.playerHealth;

    }

    private void Update()
    {
        // Calculate the direction towards the player
        Vector3 direction = player.position - transform.position;
        direction.Normalize();

        
        // Move towards the player
        transform.position += direction * nextRoomChecker.S.enemyMovementSpeed * Time.deltaTime;


        if (Time.frameCount % 60 < 30)
        {
                spriteRenderer.sprite = rightSprite;
        }
        else
        {
                spriteRenderer.sprite = leftSprite;
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
                hpStorePlayer.S.playerHealth -= nextRoomChecker.S.meleeDamage;
            }
            
        }
    }
}