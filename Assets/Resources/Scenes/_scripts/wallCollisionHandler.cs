using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallCollisionHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Player has collided with the wall

            
            playerMovement playerMovement = collision.gameObject.GetComponent<playerMovement>();
            playerMovement.StopMovement();
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("bullet"))
        {
            
            if(!other.gameObject.name.Contains("RPG"))
            {
                Destroy(other.gameObject);

            }
                
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
