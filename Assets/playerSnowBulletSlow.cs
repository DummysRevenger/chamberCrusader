using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSnowBulletSlow : MonoBehaviour
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
            enemyHit.gameObject.GetComponent<meleeEnemy>().movementSpeed *= 2;
        }
        else if (enemyHit.gameObject.GetComponent<randomMovementAdvanced>() != null)
        {
            
            enemyHit.gameObject.GetComponent<randomMovementAdvanced>().movementSpeed = 1;
            
        }
        else if (enemyHit.gameObject.GetComponent<jumpAtPlayer>() != null)
        {
            enemyHit.gameObject.GetComponent<jumpAtPlayer>().movementSpeed *= 2;
        }
        else if (enemyHit.gameObject.GetComponent<spiderJumpAtPlayer>() != null)
        {
            enemyHit.gameObject.GetComponent<spiderJumpAtPlayer>().jumpPower *= 2;
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
                enemyHit.gameObject.GetComponent<meleeEnemy>().movementSpeed /= 2;
            }
            else if (other.gameObject.GetComponent<randomMovementAdvanced>() != null)
            {

                



                other.gameObject.GetComponent<randomMovementAdvanced>().movementSpeed = 0.5f;




            }
            else if (other.gameObject.GetComponent<jumpAtPlayer>() != null)
            {
                other.gameObject.GetComponent<jumpAtPlayer>().movementSpeed /= 2;
            }
            else if (other.gameObject.GetComponent<spiderJumpAtPlayer>() != null)
            {
                other.gameObject.GetComponent<spiderJumpAtPlayer>().jumpPower /= 2;
            }


            Invoke("reEnableMovement", 2f);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
