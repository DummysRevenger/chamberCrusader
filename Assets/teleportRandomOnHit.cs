using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportRandomOnHit : MonoBehaviour
{

    private float randomX;
    private float randomY; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {


        

        if (collision.gameObject.CompareTag("sword") || collision.gameObject.CompareTag("Player") || collision.gameObject.name.Contains("shield"))
        {
            randomTeleport();
        }


    }

    void randomTeleport()
    {
        // generate random x between -7 and 7
        randomX = Random.Range(-7, 7);
        // generate random y between 4 and -4
        randomY = Random.Range(-4, 4);

        // set location to the generated x and y values
        transform.position = new Vector2(randomX, randomY);
    }

    void OnTriggerEnter2D(Collider2D other)
    {




        if (other.CompareTag("sword"))
        {
            randomTeleport();
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
