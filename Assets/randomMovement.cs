using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomMovement : MonoBehaviour
{

    public Rigidbody2D rb2D;

    private float randomDirection;

    private Vector2 direction;

    public int speed = 1;

    public float changeDirectionTime = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        changeDirection();


        randomDirection = 0;
        direction = new Vector2(0, 1);
        
    }

    void changeDirection()
    {



        randomDirection = Random.Range(0, 4);



        Invoke("changeDirection", changeDirectionTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.CompareTag("metawall"))
        {
            

            if (direction == new Vector2(0,-1))
            {
                direction = new Vector2(0, 1); // move up
                randomDirection = 0;

                
            }
            else if (direction == new Vector2(0, 1))
            {
                direction = new Vector2(0, -1); // move down
                randomDirection = 2;
                
            }

            if (direction == new Vector2(1, 0))
            {
                direction = new Vector2(-1, 0); // move left
                randomDirection = 1;
            }
            else if(direction == new Vector2(-1, 0))
            {
                direction = new Vector2(1, 0); // move right
                randomDirection = 3;
            }



        }



    }


    // Update is called once per frame
    void Update()
    {
        switch(randomDirection)
        {
            case 0: // moving up

                if (direction != new Vector2(0, -1))
                {
                    direction = new Vector2(0, 1); 
                }
                break;

            case 1: // moving left
                if (direction != new Vector2(-1, 0))
                {
                    direction = new Vector2(1, 0);
                }
                break;

            case 2: // moving down
                if (direction != new Vector2(0, 1))
                {
                    direction = new Vector2(0, -1);
                }
                break;

            case 3: // moving right
                if (direction != new Vector2(1, 0))
                {
                    direction = new Vector2(-1, 0);
                }
                break;
        }

        rb2D.velocity = direction * speed;



    }
}
