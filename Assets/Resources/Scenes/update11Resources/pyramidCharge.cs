using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pyramidCharge : MonoBehaviour
{
    public GameObject player;

    private Rigidbody2D rb;

    private Animator animator;

    private int animationNumber;

    private PolygonCollider2D polygonCollider2D;

    private Vector3 velocityBeforeStop;

    private bool charging;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        //rb.constraints = RigidbodyConstraints2D.None;

        polygonCollider2D = GetComponent<PolygonCollider2D>();

        animationNumber = 3;

        

        Invoke("charge", 5f);

        animator = GetComponent<Animator>();

        animator.SetInteger("phase", animationNumber);

        ShrinkPolygonCollider();
        
    }

    private void ShrinkPolygonCollider()
    {
        Vector2[] points = polygonCollider2D.points;

        // Shrink the polygon collider by adjusting the positions of its vertices
        for (int i = 0; i < points.Length; i++)
        {
            points[i] *= 0.6f;
        }

        polygonCollider2D.points = points;
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

    void charge()
    {

        rb.mass = 1f;
        Vector2 direction = (player.transform.position - transform.position).normalized;

        rb.AddForce(direction * 18f, ForceMode2D.Impulse);

        flipSprite();

        

        animationNumber = 5;

        animator.SetInteger("phase", animationNumber);

        



        Invoke("charge", 5f);


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

        


        if (collision.gameObject.CompareTag("Player") && pyramidTransition.stage5Begun)
        {
            // Get the player's health component
            collision.gameObject.GetComponent<hpStorePlayer>().playerHealth -= 300;

            
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
