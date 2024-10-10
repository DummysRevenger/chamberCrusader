using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantShootProjectiles : MonoBehaviour
{

    private float shootingCooldown = 5f;
    private float shootingTimer = 0f;

    public GameObject poisonCloudPrefab;

    public GameObject sporePrefab;

    public Transform player;

    

    


    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    void shootSpore()
    {
        GameObject bullet = Instantiate(sporePrefab, transform.position, Quaternion.identity);

        Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
        Vector2 direction = (player.position - transform.position).normalized;
        bulletRigidbody.velocity = direction * 6;

    }

    void shootPoisonCloud()
    {
        GameObject bullet3 = Instantiate(poisonCloudPrefab, transform);
        Rigidbody2D bulletRigidbody3 = bullet3.GetComponent<Rigidbody2D>();
        Vector2 direction3 = (player.position - transform.position).normalized;
        bulletRigidbody3.velocity = direction3 * 3f;

        float angle = Mathf.Atan2(direction3.y, direction3.x) * Mathf.Rad2Deg;

        bullet3.transform.rotation = Quaternion.Euler(0f, 0f, angle);


    }

   

    // Update is called once per frame
    void Update()
    {


        if (shootingTimer <= 0f)
        {
            shootingTimer = shootingCooldown;



            if (!gameObject.name.Contains("thePlant"))
            {
                Invoke("shootSpore", 1f);

                Invoke("shootPoisonCloud", 5f);
            }
            else
            {
                Invoke("shootSpore", 1f);

                Invoke("shootSpore", 3f);

                Invoke("shootPoisonCloud", 3f);
            }

        }
        else
        {
            shootingTimer -= Time.deltaTime;
        }


    }
}
