using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burnPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        

    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerIsOnFire.S.burn();
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerIsOnFire.S.burn();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
