using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boomerangMovement : MonoBehaviour
{

    private Rigidbody2D rb;

    private Vector2 rbVelocity;

    private bool reverse = false;

    private float zAngle = 0f;

    // Start is called before the first frame update
    void Start()
    {

        

        rb = GetComponent<Rigidbody2D>();

        

        rbVelocity = rb.velocity;


        Invoke("DestroyProjectile", 5f);

    }

    

    private void DestroyProjectile()
    {
        Destroy(gameObject);
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("metawall"))
        {
            
            rb.velocity = -rb.velocity;
        }
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity -= rbVelocity * 0.01f;
        
        /*zAngle += 15f;

        // rotate z angle
        transform.rotation = Quaternion.Euler(0f, 0f, zAngle);*/


    }
}
