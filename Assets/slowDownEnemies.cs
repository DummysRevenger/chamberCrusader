using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowDownEnemies : MonoBehaviour
{

    public float slowFactor = 1.2f;

    private float detectionRadius = 4f;

    // Start is called before the first frame update
    void Start()
    {

    }

    void CheckForNearbyEnemies()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");

        foreach (GameObject enemy in enemies)
        {


            float distance = Vector2.Distance(transform.position, enemy.transform.position);

            if (distance <= detectionRadius)
            {
                // Additional logic for handling detected enemy

                if (enemy.gameObject.CompareTag("bullet"))
                {
                    Rigidbody2D rb = enemy.gameObject.GetComponent<Rigidbody2D>();

                    rb.velocity = Vector3.zero;
                }

                if (enemy.gameObject.CompareTag("enemy") && !gameObject.name.Contains("necromancer"))
                {
                    if (enemy.GetComponent<meleeEnemy>() != null
                        && !enemy.GetComponent<meleeEnemy>().enemySlowedDown)
                    {
                        enemy.GetComponent<meleeEnemy>().movementSpeed /= slowFactor;
                        enemy.GetComponent<meleeEnemy>().enemySlowedDown = true;
                    }

                    if (enemy.GetComponent<rangedEnemy>() != null
                        && !enemy.GetComponent<rangedEnemy>().enemySlowedDown)
                    {
                        enemy.GetComponent<rangedEnemy>().chaseSpeed /= slowFactor;
                        enemy.GetComponent<rangedEnemy>().enemySlowedDown = true;
                        enemy.GetComponent<rangedEnemy>().retreatSpeed /= slowFactor;
                    }

                    if (enemy.GetComponent<jumpAtPlayer>() != null
                        && !enemy.GetComponent<jumpAtPlayer>().enemySlowedDown)
                    {
                        enemy.GetComponent<jumpAtPlayer>().movementSpeed /= slowFactor;
                        enemy.GetComponent<jumpAtPlayer>().enemySlowedDown = true;
                    }

                    if (enemy.GetComponent<spiderJumpAtPlayer>() != null
                        && !enemy.GetComponent<spiderJumpAtPlayer>().enemySlowedDown)
                    {
                        enemy.GetComponent<spiderJumpAtPlayer>().enemySlowedDown = true;
                        enemy.GetComponent<spiderJumpAtPlayer>().jumpPower /= slowFactor;
                        enemy.GetComponent<spiderJumpAtPlayer>().jumpCooldown /= slowFactor;
                    }

                    if (enemy.GetComponent<randomMovementAdvanced>() != null
                        && !enemy.GetComponent<randomMovementAdvanced>().enemySlowedDown)
                    {
                        enemy.GetComponent<randomMovementAdvanced>().enemySlowedDown = true;
                        enemy.GetComponent<randomMovementAdvanced>().movementSpeed /= slowFactor;
                    }

                    if (enemy.GetComponent<ghostDragon>() != null
                        && !enemy.GetComponent<ghostDragon>().enemySlowedDown)
                    {
                        enemy.GetComponent<ghostDragon>().enemySlowedDown = true;
                        enemy.GetComponent<ghostDragon>().movementSpeed /= slowFactor;
                    }
                }
            }
        }

    }

  

    // Update is called once per frame
    void Update()
    {

        CheckForNearbyEnemies();



    }
}
