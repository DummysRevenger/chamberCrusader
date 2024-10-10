using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletStealHealth : MonoBehaviour
{
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("enemy") || 
            other.gameObject.CompareTag("rangedEnemy"))
        {
            if (player.GetComponent<hpStorePlayer>().playerHealth < 
                player.GetComponent<hpStorePlayer>().maxHealth)
            {
                player.GetComponent<hpStorePlayer>().playerHealth += 20;

            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
