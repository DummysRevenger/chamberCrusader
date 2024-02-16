using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oasisHealing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            

            if (hpStorePlayer.S.playerHealth < hpStorePlayer.S.maxHealth)
            {
                
                hpStorePlayer.S.playerHealth += 1f;
            }
            
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
