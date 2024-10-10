using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomMovementAdvanced : MonoBehaviour //advanced because it's slightly smarter
    // as in it will move towards the player more often by using the player's position
{
    public Rigidbody2D rb2D;

    public GameObject player;

    private float randomDirection;

    private Vector2 direction;

    public bool Webbed;

    public float movementSpeed = 1;

    public bool enemySlowedDown;



    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");

        rb2D = GetComponent<Rigidbody2D>();
        randomDirection = Random.Range(0, 4);
        direction = new Vector2(1, 0);
        changeDirection();
    }



    void changeDirection()
    {
        randomDirection = Random.Range(0, 4);

        if (transform.position.x < player.transform.position.x && randomDirection == 3) // if the paladin is to the left of the player but wants to go left
        {
            randomDirection = 1;
        }
        else if(transform.position.x > player.transform.position.x && randomDirection == 1)
        {
            randomDirection = 3;
        }
        
        if (transform.position.y < player.transform.position.y && randomDirection == 2)
        {
            randomDirection = 0;
        }
        else if(transform.position.y > player.transform.position.y && randomDirection == 0)
        {
            randomDirection = 2; 
        }
        
        Invoke("changeDirection", 2f);
    }



    // Update is called once per frame
    void Update()
    {
        switch (randomDirection)
        {
            case 0: // go up

                if (direction != new Vector2(0, -1))
                {
                    direction = new Vector2(0, 1);
                }
                break;

            case 1: // go right
                if (direction != new Vector2(-1, 0))
                {
                    direction = new Vector2(1, 0);
                }
                break;

            case 2: // go down
                if (direction != new Vector2(0, 1))
                {
                    direction = new Vector2(0, -1);
                }
                break;

            case 3: // go left
                if (direction != new Vector2(1, 0))
                {
                    direction = new Vector2(-1, 0);
                }
                break;
        }

        if (!Webbed)
        {
            rb2D.velocity = direction * movementSpeed;
        }



    }
}
