using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyToClosestEnemy : MonoBehaviour
{

    private bool enemyFound;

    private GameObject targetEnemy;

    private bool movementEnabled = false;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("disappear", 8f);

        targetEnemy = GetClosestObject();

        enemyFound = true;

        Invoke("enableMovement", 1f);

        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        int randomx = Random.value < 0.5f ? -1 : 1;
        int randomy = Random.value < 0.5f ? -1 : 1;

        int randomForce = Random.Range(6, 10);

        Vector3 direction = new Vector3(randomx, randomy, 0f);


        direction.Normalize();

        rb.AddForce(direction * randomForce, ForceMode2D.Impulse);
    }

    void enableMovement()
    {
        movementEnabled = false;
    }


    GameObject GetClosestObject()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag("enemy");
        GameObject closest = null;
        float closestDistance = 30;

        foreach (GameObject target in targets)
        {
            float distance = Vector3.Distance(transform.position, target.transform.position);
            if (distance < closestDistance)
            {
                closestDistance = distance;
                closest = target;
            }
        }

        return closest;
    }



    void disappear()
    {
        Destroy(gameObject);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("enemy") || other.gameObject.CompareTag("rangedEnemy"))
        {
            other.gameObject.GetComponent<hpStore>().health -= 50 * Time.deltaTime;

            
        }
    }


    // Update is called once per frame
    void Update()
    {
        // Calculate the direction towards the player



        if (targetEnemy != null)
        {
            if (targetEnemy.gameObject.CompareTag("enemy"))
            {

                Vector3 direction = targetEnemy.transform.position - transform.position;
                direction.Normalize();


                // Move towards the player
                transform.position += direction * 5f * Time.deltaTime;


            }
            else
            {
                enemyFound = false;
            }


        }


        if (!enemyFound)
        {
            targetEnemy = GetClosestObject();


            enemyFound = true;
        }





    }
}
