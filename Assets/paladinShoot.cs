using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paladinShoot : MonoBehaviour
{

    public GameObject bullet;

    private int shootingRange = 4;

    private float bulletSpeed = 12f;
    private float shootingCooldown = 4f;

    public GameObject bulletPrefab;

    private GameObject player;

    private bool shooting = false;

    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindWithTag("Player");

        beginShooting();


    }

    void beginShooting()
    {
        if (shooting)
        {
            shoot();
            Invoke("shoot", 0.25f);
            Invoke("shoot", 0.5f);
            Invoke("shoot", 0.75f);
            Invoke("shoot", 1f);
        }
        Invoke("beginShooting", shootingCooldown);
    }

    void shoot()
    {
        // Instantiate a bullet and set its velocity towards the player
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);


            Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
            Vector2 direction = (player.transform.position - transform.position).normalized;
            bulletRigidbody.velocity = direction * bulletSpeed;

            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.Play();
        
    }


    // Update is called once per frame
    void Update()
    {

        float distanceToPlayer = Vector2.Distance(transform.position, player.transform.position);


        if (distanceToPlayer > shootingRange)
        {
            shooting = true;
        }
        else
        {
            shooting = false;
        }
    }
}
