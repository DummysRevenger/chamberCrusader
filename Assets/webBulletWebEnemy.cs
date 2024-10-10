using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class webBulletWebEnemy : MonoBehaviour
{

    private GameObject enemyHit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void reEnableMovement()
    {
        if (enemyHit.gameObject.GetComponent<meleeEnemy>() != null)
        {
            enemyHit.gameObject.GetComponent<meleeEnemy>().Webbed = false;

            Debug.Log("unwebbed");

        }
        else if (enemyHit.gameObject.GetComponent<randomMovementAdvanced>() != null)
        {
            enemyHit.gameObject.GetComponent<randomMovementAdvanced>().enabled = true;



            enemyHit.gameObject.GetComponent<randomMovementAdvanced>().Webbed = false;
        }
        else if (enemyHit.gameObject.GetComponent<jumpAtPlayer>() != null)
        {
            enemyHit.gameObject.GetComponent<jumpAtPlayer>().enabled = true;
        }
        else if (enemyHit.gameObject.GetComponent<spiderJumpAtPlayer>() != null)
        {
            enemyHit.gameObject.GetComponent<spiderJumpAtPlayer>().enabled = true;
        }
    }

    void disableReenabling()
    {
        CancelInvoke("reEnableMovement");
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        enemyHit = other.gameObject;

        if (other.gameObject.CompareTag("enemy")
            || other.gameObject.CompareTag("rangedEnemy"))
        {
            if (other.gameObject.GetComponent<meleeEnemy>() != null)
            {
                

                other.gameObject.GetComponent<meleeEnemy>().Webbed = true;


                
            }
            else if (other.gameObject.GetComponent<randomMovementAdvanced>() != null)
            {

                other.gameObject.GetComponent<randomMovementAdvanced>().Webbed = true;

                other.gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;


                other.gameObject.GetComponent<randomMovementAdvanced>().enabled = false;

                


            }
            else if (other.gameObject.GetComponent<jumpAtPlayer>() != null)
            {
                other.gameObject.GetComponent<jumpAtPlayer>().enabled = false;
            }
            else if (other.gameObject.GetComponent<spiderJumpAtPlayer>() != null)
            {
                other.gameObject.GetComponent<spiderJumpAtPlayer>().enabled = false;
            }

            CancelInvoke("reEnableMovement");


            if (gameObject.name.Contains("Web"))
            {
                Invoke("reEnableMovement", 0.5f);
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
