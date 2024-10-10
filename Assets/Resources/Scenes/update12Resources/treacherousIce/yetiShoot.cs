using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yetiShoot : MonoBehaviour
{


    private int shootingRange = 4;

    private float bulletSpeed = 6f;
    private float shootingCooldown = 4f;

    private bool onCooldown;


    private Animator theAnimator;

    private GameObject player;

    private bool shooting = false;

    public GameObject iceBall;

    public GameObject snowBall;

    private Vector3 aimDirection;

    // Start is called before the first frame update
    void Start()
    {

        theAnimator = GetComponent<Animator>();

        player = GameObject.FindWithTag("Player");

        beginShooting();


    }

    void beginShooting()
    {
        if (shooting)
        {
            shoot();
        }
        Invoke("beginShooting", shootingCooldown);
    }

    void cooldown()
    {
        onCooldown = true;
    }

    void shoot()
    {

        theAnimator.SetTrigger("throw");

        aimDirection = (player.transform.position - transform.position).normalized;

        onCooldown = false;

        


        for (int i = 1; i < 6; i++)
        {

            float randomAngle = Random.Range(-0.2f, 0.2f);

            Vector3 spreadRotation = new Vector3(Mathf.Abs(randomAngle), randomAngle, 0f);


            int randomChoice = Random.Range(0, 2);

            GameObject bullet4;

            if (randomChoice == 0)
            {
                bullet4 = Instantiate(iceBall, transform.position, Quaternion.identity);
            }
            else
            {
                bullet4 = Instantiate(snowBall, transform.position, Quaternion.identity);
            }

            
            Rigidbody2D bulletRigidbody4 = bullet4.GetComponent<Rigidbody2D>();
            
            bulletRigidbody4.velocity = 10f * (aimDirection + spreadRotation).normalized;
        }

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
