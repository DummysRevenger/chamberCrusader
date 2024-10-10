using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thrombusShootProjectiles : MonoBehaviour
{
    private float shootingCooldown = 4f;
    private float shootingTimer = 0f;

    public GameObject boomerangPrefab;

    public GameObject stunPrefab;

    public GameObject hypnoPrefab;

    public GameObject hypnoBeamPrefab;

    public Transform player;

    private float boomerangSpeed = 7f;

    public GameObject stunBeamPrefab;


    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    void shootBoomerang()
    {
        GameObject bullet = Instantiate(boomerangPrefab, transform.position, Quaternion.identity);

        Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
        Vector2 direction = (player.position - transform.position).normalized;
        bulletRigidbody.velocity = direction * boomerangSpeed;

    }

    void shootBigHypno()
    {
        GameObject bullet3 = Instantiate(hypnoBeamPrefab, transform);
        Rigidbody2D bulletRigidbody3 = bullet3.GetComponent<Rigidbody2D>();
        Vector2 direction3 = (player.position - transform.position).normalized;
        bulletRigidbody3.velocity = direction3 * 3f;

        float angle = Mathf.Atan2(direction3.y, direction3.x) * Mathf.Rad2Deg;

        bullet3.transform.rotation = Quaternion.Euler(0f, 0f, angle);


    }

    void shootStun()
    {
        GameObject bullet4 = Instantiate(stunBeamPrefab, transform);
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

            

            GameObject bullet2 = Instantiate(hypnoPrefab, transform);

            

            

            shootBoomerang();

            Invoke("shootBoomerang", 1f);

            Invoke("shootBoomerang", 2f);

            Invoke("shootBoomerang", 3f);

            Invoke("shootBigHypno", 1f);

            Invoke("shootBigHypno", 3f);

            shootStun();




















            




        }
        else
        {
            shootingTimer -= Time.deltaTime;
        }


    }



}
