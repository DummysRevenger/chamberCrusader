using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloodSkullShoot : MonoBehaviour
{
    public Transform player;

    private float shootingRange = 60f;

    
    



    public GameObject bulletPrefab;


    private float bulletSpeed = 4f;
    private float shootingCooldown = 1f;
    

    public GameObject bullet;



    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        Shoot();
    }

    private void Shoot()
    {
        // Instantiate a bullet and set its velocity towards the player

        
        
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
            Vector2 direction = (player.position - transform.position).normalized;
            bulletRigidbody.velocity = direction * bulletSpeed;

            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.Play();
        

        Invoke("Shoot", shootingCooldown);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
