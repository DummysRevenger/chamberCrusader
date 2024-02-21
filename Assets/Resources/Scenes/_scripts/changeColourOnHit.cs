using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColourOnHit : MonoBehaviour
{
    private float currentHealth;
    private float previousHealth;
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

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bullet") || collision.gameObject.CompareTag("enemy") || (collision.gameObject.CompareTag("wall") && selectCharacter.mapSelected == "desert"))
        {
            GetComponent<SpriteRenderer>().color = new Color(1f, 78f/255f, 78f/255f);


        }
        
    }


    

    void OnTriggerEnter2D(Collider2D collision)
    {

        


        if (collision.gameObject.CompareTag("bullet") || (collision.gameObject.CompareTag("wall") && selectCharacter.mapSelected == "desert"))
        {
            GetComponent<SpriteRenderer>().color = new Color(1f, 78f / 255f, 78f / 255f);

            StartCoroutine(changeColourToWhite());
        }

        if ( (collision.gameObject.CompareTag("wall") ) || collision.gameObject.name.Contains("ghost") || collision.gameObject.name.Contains("spike") )
            {
            GetComponent<SpriteRenderer>().color = new Color(1f, 78f / 255f, 78f / 255f);

            Debug.Log("colliding with ghost");
            }


    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if ((collision.gameObject.CompareTag("wall")) || collision.gameObject.name.Contains("ghost") || collision.gameObject.name.Contains("spike"))
        {
            GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bullet") || collision.gameObject.CompareTag("enemy") || (collision.gameObject.CompareTag("wall") && selectCharacter.mapSelected == "desert"))
        {
            GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);

        }
    }



    // Update is called once per frame
    void Update()
    {
        


        
    }
}
