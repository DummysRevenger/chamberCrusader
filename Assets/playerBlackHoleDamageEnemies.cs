using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBlackHoleDamageEnemies : MonoBehaviour
{

    //attach this to every enemy (oof)

    private float detectionRadius;
    

    // Start is called before the first frame update
    void Start()
    {
        

        if (gameObject.name.Contains("1"))
        {
            detectionRadius = 5;
        }
        else if (gameObject.name.Contains("2"))
        {
            detectionRadius = 3;
        }
        else if (gameObject.name.Contains("3"))
        {
            detectionRadius = 1.5f;
        }
    }

    void CheckForNearbyEnemies()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");

        foreach (GameObject enemy in enemies)
        {
            float distance = Vector2.Distance(transform.position, enemy.transform.position);


            


            if (distance <= detectionRadius)
            {
                Debug.Log("Enemy detected: " + enemy.name + " at distance: " + distance);
                // Additional logic for handling detected enemy

                if (enemy.GetComponent<hpStore>() != null)
                {
                    enemy.GetComponent<hpStore>().health -= 50 * Time.deltaTime;
                }


                /*
                if (enemy.GetComponent<hpStorePlayer>() != null)
                {
                    enemy.GetComponent<hpStorePlayer>().playerHealth -= 50 * Time.deltaTime;
                }
                */


            }
        }
    }

        // Update is called once per frame
    void Update()
    {
        CheckForNearbyEnemies();
    }

    
}
