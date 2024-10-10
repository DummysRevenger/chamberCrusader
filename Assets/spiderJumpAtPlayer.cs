using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiderJumpAtPlayer : MonoBehaviour
{


    public int jumpingRange = 7;

    private GameObject player;

    private Rigidbody2D rb2d;

    private bool onCooldown = false;

    private Vector2 direction;

    public float jumpCooldown = 1.5f;

    public float jumpPower;

    public bool enemySlowedDown;
    


    private Animator theAnimator;

    // Start is called before the first frame update
    void Start()
    {
        theAnimator = GetComponent<Animator>();

        player = GameObject.FindGameObjectWithTag("Player");

        rb2d = GetComponent<Rigidbody2D>();



        jumpPower = 50f;

        if (gameObject.name.Contains("giantFrog"))
        {
            jumpCooldown = 1f;
            jumpingRange = 999;
        }
        else if (gameObject.name.Contains("crocodile"))
        {
            jumpCooldown = 2f;
            jumpingRange = 999;
        }
        else
        {
            jumpCooldown = 0.5f;
            jumpingRange = 999;

            
        }


    }


    void jump()
    {
        rb2d.AddForce(direction * jumpPower, ForceMode2D.Impulse);


        
        
    }

    void offCooldown()
    {
        onCooldown = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            hpStorePlayer.S.playerHealth -= 10 + 2 * nextRoomChecker.S.roomNumber;
        }
    }

    // Update is called once per frame
    void Update()
    {


        if (gameObject.name.Contains("giantFrog"))
        {
            jumpCooldown = 1f;
            jumpingRange = 999;
        }
        else if (gameObject.name.Contains("crocodile"))
        {
            jumpCooldown = 2f;
            jumpingRange = 999;
        }
        else
        {
            jumpCooldown = 0.5f;
            jumpingRange = 999;

        }

        float distanceToPlayer = Vector2.Distance(player.transform.position, transform.position);

        direction = (player.transform.position - transform.position ).normalized;


        if (distanceToPlayer <= jumpingRange && !onCooldown)
        {
            

            onCooldown = true;

            jump();

            Invoke("offCooldown", jumpCooldown);


            if (gameObject.name.Contains("caveSpider"))
            {
                
            }

        }
        
        
    }
}
