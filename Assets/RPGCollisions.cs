using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGCollisions : MonoBehaviour
{

    public GameObject explosion;


    

    void OnTriggerEnter2D(Collider2D collision)
    {

        


        if (collision.gameObject.CompareTag("wall") || collision.gameObject.CompareTag("metawall") || collision.gameObject.CompareTag("enemy"))
        {
            Instantiate(explosion, transform.position, Quaternion.identity);

            

            Destroy(gameObject);
        }

        

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
