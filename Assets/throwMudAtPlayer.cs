using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwMudAtPlayer : MonoBehaviour
{

    private meleeEnemy movementScript;

    public GameObject mudProjectile;

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        movementScript = GetComponent<meleeEnemy>();

        player = GameObject.FindGameObjectWithTag("Player");

        Invoke("throwMud", 1f);

        
    }


    void createHail(int hailOffset)
    {



        GameObject bullet = Instantiate(mudProjectile, transform.position, Quaternion.identity);

        Vector3 offset = new Vector3(hailOffset, hailOffset, 0f);

        Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
        Vector3 direction = (offset + player.transform.position - transform.position).normalized;
        bulletRigidbody.velocity = direction * 5;


    }

    

    void throwMud()
    {

        if (gameObject.name == "sludgeElemental")
        {
            for (int i = -5; i < 5; i++)
            {
                GameObject bullet = Instantiate(mudProjectile, transform.position, Quaternion.identity);

                Vector3 offset = new Vector3(i, i, 0f);

                Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
                Vector3 direction = (offset + player.transform.position - transform.position).normalized;
                bulletRigidbody.velocity = direction * 5;
            }
        }
        else
        {
            GameObject bullet = Instantiate(mudProjectile, transform.position, Quaternion.identity);
            Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
            Vector2 direction = (player.transform.position - transform.position).normalized;
            bulletRigidbody.velocity = direction * 9f;
        }

        

        Invoke("throwMud", 1.8f);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
