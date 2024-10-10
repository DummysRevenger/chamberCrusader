using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pyramidHazardDoDamage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void timedDestruction()
    {
        Destroy(gameObject);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (gameObject.name.Contains("fireBurning") && other.gameObject.CompareTag("Player"))
        {
            hpStorePlayer.S.playerHealth -= 4;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            if (gameObject.name.Contains("fireFalling"))
            {
                hpStorePlayer.S.playerHealth -= 60;
                Invoke("timedDestruction", 0.1f);
            }

            if (gameObject.name.Contains("hail"))
            {
                hpStorePlayer.S.playerHealth -= 30;
                Invoke("timedDestruction", 0.1f);
            }

            

            if (gameObject.name.Contains("lightning"))
            {
                hpStorePlayer.S.playerHealth -= 400;
            }

        }

    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
