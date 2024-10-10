using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHornetAttackPlayer : MonoBehaviour
{

    private GameObject player;

    private Rigidbody2D rb;

    private Vector3 velocityBeforeStop;

    private bool charging;

    public GameObject stingerPrefab;

    private GameObject theStinger;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        attack();

        charge();

    }

    void attack()
    {
        int attackChoice = Random.Range(0, 3);

        switch(attackChoice)
        {
            case 0: case 1:
                charge();
                break;
            case 2:
                shootStinger();
                break;
        }

        Invoke("attack", 2f);
    }

    void shootStinger()
    {
        GameObject bullet = Instantiate(stingerPrefab, transform.position, Quaternion.identity);
        Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
        Vector2 direction = (player.transform.position - transform.position).normalized;
        bulletRigidbody.velocity = direction * 14;
    }

    void charge()
    {
            Vector2 direction = (player.transform.position - transform.position).normalized;

            rb.AddForce(direction * 30f, ForceMode2D.Impulse);

            flipSprite();

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
            collision.gameObject.GetComponent<hpStorePlayer>().playerHealth -= 80;

            playerIsPoisonedStore.S.poison();
        }


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

    // Update is called once per frame
    void Update()
    {
        
    }
}
