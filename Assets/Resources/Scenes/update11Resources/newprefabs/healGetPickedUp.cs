using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healGetPickedUp : MonoBehaviour
{

    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") || other.gameObject.name == "grabberIncreasedRange")
        {



            switch(gameObject.name)
            {
                case "gummyBear(Clone)":
                    hpStorePlayer.S.playerHealth += 600;
                    break;
                case "candyCane(Clone)":
                    hpStorePlayer.S.playerHealth += 100;
                    break;
                case "candyCorn(Clone)":
                    hpStorePlayer.S.playerHealth += 100;
                    break;
                case "bonBon(Clone)":
                    hpStorePlayer.S.playerHealth += 50;
                    break;
                case "lollipop(Clone)":
                    hpStorePlayer.S.playerHealth += 50;
                    break;
                case "peanutCup(Clone)":
                    hpStorePlayer.S.playerHealth += 200;
                    break;
                case "liquorice(Clone)":
                    hpStorePlayer.S.playerHealth += 25;
                    playerIsPoisonedStore.S.unPoison();
                    break;
                case "lustHeart":

                    
                        hpStorePlayer.S.playerHealth += 10;
                    
                    break;
            }

            

            transform.position = new Vector2(99f, 99f);
            Invoke("destroy", 1f);
        }
    }

    void destroy()
    {
        Destroy(gameObject);
    }
}
