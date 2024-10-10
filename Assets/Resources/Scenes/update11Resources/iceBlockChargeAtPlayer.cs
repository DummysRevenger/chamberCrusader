using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iceBlockChargeAtPlayer : MonoBehaviour
{
    private GameObject player;

    private Rigidbody2D rb;

    private Vector3 velocityBeforeStop;

    private bool charging;

    private Animator theAnimator;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");


        theAnimator = GetComponent<Animator>();

        charge();

        Invoke("charge", 3f);

        

        

    }


    void flipSprite()
    {
        if (transform.position.x <= player.transform.position.x)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }

    }

    void becomeIdle()
    {
        theAnimator.SetBool("charging", false);
    }

    void charge()
    {

        
        Vector2 direction = (player.transform.position - transform.position).normalized;

        rb.AddForce(direction * 35f, ForceMode2D.Impulse);

        flipSprite();

        Invoke("charge", 3f);

        theAnimator.SetBool("charging", true);


        Invoke("becomeIdle", 2f);
    }






    void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.CompareTag("metawall") || collision.gameObject.CompareTag("Player"))
        {



            // Get the normal of the collision surface
            Vector3 normal = collision.contacts[0].normal;



            // Calculate the reflection vector
            Vector3 reflectionVector = Vector3.Reflect(velocityBeforeStop, normal);

            if (rb != null)
            {
                rb.velocity = reflectionVector;
            }

        }




        if (collision.gameObject.CompareTag("Player"))
        {
            // Get the player's health component
            collision.gameObject.GetComponent<hpStorePlayer>().playerHealth -= 100;


        }




    }






    // Update is called once per frame
    void Update()
    {
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;

        if (rb.velocity != Vector2.zero)
        {
            velocityBeforeStop = rb.velocity;
        }


    }
}
