using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poisonThePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            playerIsPoisonedStore.S.poison();

            playerIsPoisonedStore.S.stopUnpoisoning();
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            playerIsPoisonedStore.S.poison();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
