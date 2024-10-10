using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieAttackDoDamage : MonoBehaviour
{

    private bool hitWall = false;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            Vector2 directionFromObjectToPlayer = collision.transform.position - transform.position;


            RaycastHit2D hit = Physics2D.Raycast(transform.position, directionFromObjectToPlayer, directionFromObjectToPlayer.magnitude);

            // Ray hit an object
            if (hit.collider != null && hit.collider.CompareTag("wall")) { hitWall = true; }

            if (!hitWall)
            {

                if (gameObject.name.Contains("crocodile"))
                {
                    hpStorePlayer.S.playerHealth -= 150;
                }
                else if (gameObject.name.Contains("yetiDemon"))
                {
                    hpStorePlayer.S.playerHealth -= 177;

                    playerIsFrozenStore.S.freeze();
                }
                else if (gameObject.name.Contains("strongZombie"))
                {
                    hpStorePlayer.S.playerHealth -= 100;
                }
                else if (gameObject.name.Contains("fireDemon") 
                    || gameObject.name.Contains("giantFrog"))
                {
                    hpStorePlayer.S.playerHealth -= 80;
                }
                else if (gameObject.name.Contains("viperfish"))
                {
                    hpStorePlayer.S.playerHealth -= 90;

                    playerIsPoisonedStore.S.poison();
                    playerIsPoisonedStore.S.stopUnpoisoning();

                }

            }
            

        }
    }





    // Update is called once per frame
    void Update()
    {
        
    }
}
