using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColourOnHit : MonoBehaviour
{
    private float currentHealth;
    private float previousHealth;


   


    public GameObject shield;

    private activateShield activateShieldScript;

    private protectiveAbility protectiveScript;






    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    IEnumerator changeCurrentHealth()
    {
        currentHealth = hpStorePlayer.S.playerHealth;
        yield return new WaitForSeconds(0.2f);
        previousHealth = hpStorePlayer.S.playerHealth;
    }
    
    IEnumerator changeColourToWhite()
    {

        yield return new WaitForSeconds(0.3f);

        GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);

    }


    




    void OnTriggerEnter2D(Collider2D collision)
    {
        

        if (gameObject.name == "player") // if the player is the knight
        {

            if (protectiveScript != null)
            {
                if (!protectiveScript.abilityRunning)
                {
                    if (!protectiveScript.abilityRunning &&
                        !collision.gameObject.name.Contains("scytheRay") && !collision.gameObject.name.Contains("Fork") && !collision.gameObject.name.Contains("coinBullet") &&
                        (collision.gameObject.CompareTag("hazard") || collision.gameObject.CompareTag("bullet") 
                        || (collision.gameObject.CompareTag("wall") && selectCharacter.mapSelected == "desert") && hpStorePlayer.S.playerHealth > 0))
                    {

                        GetComponent<SpriteRenderer>().color = new Color(1f, 78f / 255f, 78f / 255f);

                    }



                    if (!protectiveScript.abilityRunning && !collision.gameObject.name.Contains("Fork") && 
                        !collision.gameObject.name.Contains("scytheRay") && !collision.gameObject.name.Contains("coinBullet")
                        && (collision.gameObject.CompareTag("hazard") || collision.gameObject.CompareTag("wall")) 
                        || collision.gameObject.name.Contains("ghost") || collision.gameObject.name.Contains("spike") && hpStorePlayer.S.playerHealth > 0)
                    {
                        GetComponent<SpriteRenderer>().color = new Color(1f, 78f / 255f, 78f / 255f);

                    }
                    
                }
            }
        }
        else // if the player is any other character
        {

            if (!collision.gameObject.name.Contains("scytheRay") && !collision.gameObject.name.Contains("Fork") && !collision.gameObject.name.Contains("coinBullet") && (collision.gameObject.CompareTag("bullet") || collision.gameObject.CompareTag("enemy")
                        || (collision.gameObject.CompareTag("wall") && selectCharacter.mapSelected == "desert") && hpStorePlayer.S.playerHealth > 0))
            {
                GetComponent<SpriteRenderer>().color = new Color(1f, 78f / 255f, 78f / 255f);


                


            }
        }

    }



    void OnTriggerExit2D(Collider2D collision)
    {
        StartCoroutine(changeColourToWhite());

        if (protectiveScript != null)
        {
            if (!protectiveScript.abilityRunning)
            {
                if (!protectiveAbility.S.abilityRunning && (collision.gameObject.CompareTag("wall") || 
                    collision.gameObject.name.Contains("ghost") || collision.gameObject.name.Contains("spike")
                    && hpStorePlayer.S.playerHealth > 0))
                {
                    GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
                }

            }
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        StartCoroutine(changeColourToWhite());

        if (gameObject.name == "player")
        {
            if (protectiveScript != null)
            {
                if (!protectiveScript.abilityRunning)
                {
                    if (!protectiveScript.abilityRunning && !collision.gameObject.name.Contains("coinBullet") &&
                        !collision.gameObject.name.Contains("scytheRay") && !collision.gameObject.name.Contains("Fork")
                        && collision.gameObject.CompareTag("bullet") || collision.gameObject.CompareTag("enemy") || 
                        (collision.gameObject.CompareTag("wall") && selectCharacter.mapSelected == "desert") && hpStorePlayer.S.playerHealth > 0)
                    {
                        GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);

                    }

                }
            }
        }
        else
        {
            if ((!collision.gameObject.name.Contains("scytheRay") && !collision.gameObject.name.Contains("Fork") && !collision.gameObject.name.Contains("coinBullet")
                || collision.gameObject.CompareTag("bullet") || collision.gameObject.CompareTag("enemy") || (collision.gameObject.CompareTag("wall") && selectCharacter.mapSelected == "desert") && hpStorePlayer.S.playerHealth > 0))
            {
                GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
            }
        }
    }



    // Update is called once per frame
    void Update()
    {
        


        
    }
}
