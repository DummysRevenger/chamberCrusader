using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootChains : MonoBehaviour
{
    private float bulletSpeed = 7.5f;
    public GameObject chainPrefab;
    public GameObject player;
    public bool isShooting = false;

    private float shootingTimer = 0f;


    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        


        if (!isShooting)
        {
            isShooting = true;
            System.Random random = new System.Random();
            shootingTimer = random.Next(1, 4);
            Shoot();
        }

        // Update the shooting cooldown timer
        if (isShooting)
        {
            shootingTimer -= Time.deltaTime;
            if (shootingTimer <= 0f)
            {
                isShooting = false;


            }
        }
    }

    private void Shoot()
    {

        System.Random random = new System.Random();
        int randomInteger = random.Next(0, 3);


        switch (randomInteger)
        {


            case 0:

                if (chainPrefab != null)
                {
                    GameObject chain = Instantiate(chainPrefab, transform.position, Quaternion.identity);
                    Rigidbody2D bulletRigidbody = chain.GetComponent<Rigidbody2D>();
                    Vector2 direction = (player.transform.position - transform.position).normalized;
                    bulletRigidbody.velocity = direction * bulletSpeed;


                    

                    // Calculate the angle of rotation in radians
                    float angleToFace = Mathf.Atan2(direction.y, direction.x);

                    // Create a rotation quaternion with only Z rotation
                    Quaternion rotation = Quaternion.Euler(0f, 0f, angleToFace * Mathf.Rad2Deg);

                    // Apply the rotation to the object
                    chain.transform.rotation = rotation;

                    



                    AudioSource audioSource = GetComponent<AudioSource>();
                    audioSource.Play();
                }
                break;

            default:
                break;
        }
    }




    
}


