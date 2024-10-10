using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldTouchPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerIsGildedStore.S.gold();

            
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerIsGildedStore.S.unGold();


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
