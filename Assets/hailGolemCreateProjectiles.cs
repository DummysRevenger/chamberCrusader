using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hailGolemCreateProjectiles : MonoBehaviour
{

    public GameObject hailProjectile;

    private GameObject player;


    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");

        for (int i = -5; i < 5; i++)
        {
            createHail(i);
        }
        
    }

    void createHail(int hailOffset)
    {

        

        GameObject bullet = Instantiate(hailProjectile, transform.position, Quaternion.identity);

        Vector3 offset = new Vector3(hailOffset, hailOffset, 0f);

        Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
        Vector3 direction = (offset + player.transform.position - transform.position).normalized;
        bulletRigidbody.velocity = direction * 5;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
