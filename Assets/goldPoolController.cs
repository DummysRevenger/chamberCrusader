using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldPoolController : MonoBehaviour
{

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerIsGildedStore.S.gold();

            
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            hpStorePlayer.S.playerHealth -= 5;

            playerIsGildedStore.S.gold();
        }


    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerIsGildedStore.S.unGold();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
