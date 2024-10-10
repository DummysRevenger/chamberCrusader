using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abyssalHorrorShootProjectile : MonoBehaviour
{
    public GameObject voidProjectilePrefab;

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        Invoke("Shoot", 1f);
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(voidProjectilePrefab, transform.position, Quaternion.identity);
        bullet.transform.LookAt(player.transform);
        Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
        Vector2 direction = (player.transform.position - transform.position).normalized;
        bulletRigidbody.velocity = direction * 7;

        Invoke("Shoot", 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
