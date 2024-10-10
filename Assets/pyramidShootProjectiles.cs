using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pyramidShootProjectiles : MonoBehaviour
{
    private float shootingCooldown = 3f;
    private float shootingTimer = 0f;

    public Transform player;

    public GameObject stunBeamPrefab;

    public GameObject bulletPrefab;


    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player").transform;

    }


    void shootBullet()
    {
        GameObject bullet1 = Instantiate(bulletPrefab, transform.position, transform.rotation);
        Rigidbody2D bulletRigidbody1 = bullet1.GetComponent<Rigidbody2D>();
        Vector2 direction1 = (player.position - transform.position).normalized;
        bulletRigidbody1.velocity = direction1 * 10f;

        float angle = Mathf.Atan2(direction1.y, direction1.x) * Mathf.Rad2Deg;

        bullet1.transform.rotation = Quaternion.Euler(0f, 0f, angle);

    }


    void shootStun()
    {
        GameObject bullet4 = Instantiate(stunBeamPrefab, transform.position, transform.rotation);
        Rigidbody2D bulletRigidbody4 = bullet4.GetComponent<Rigidbody2D>();
        Vector2 direction4 = (player.position - transform.position).normalized;
        bulletRigidbody4.velocity = direction4 * 4f;

        float angle = Mathf.Atan2(direction4.y, direction4.x) * Mathf.Rad2Deg;

        bullet4.transform.rotation = Quaternion.Euler(0f, 0f, angle);

    }

    // Update is called once per frame
    void Update()
    {
     

        if (shootingTimer <= 0f)
        {
            shootingTimer = shootingCooldown;

            shootStun();

        }
        else
        {
            shootingTimer -= Time.deltaTime;
        }


    }



}
