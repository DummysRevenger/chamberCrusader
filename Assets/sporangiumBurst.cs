using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sporangiumBurst : MonoBehaviour
{
    private float currentHP;

    private bool burst = false;

    public GameObject sporePrefab;

    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void spawnSpores()
    {
        int randomNumber = Random.Range(0, 3);

        switch(randomNumber)
        {
            case 0:
                Instantiate(sporePrefab, transform.position, transform.rotation);
                break;
            case 1:
                Instantiate(sporePrefab, transform.position, transform.rotation);
                Instantiate(sporePrefab, transform.position, transform.rotation);
                break;
            case 2:
                Instantiate(sporePrefab, transform.position, transform.rotation);
                Instantiate(sporePrefab, transform.position, transform.rotation);
                Instantiate(sporePrefab, transform.position, transform.rotation);
                break;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name.Contains("playerBullet") || collision.gameObject.CompareTag("Player") || collision.gameObject.name.Contains("thrown"))
        {

            if (collision.gameObject.name.Contains("thrown"))
            {
                Destroy(collision.gameObject);
            }


            spawnSpores();
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.name.Contains("playerBullet") || other.gameObject.CompareTag("Player") || other.gameObject.name.Contains("thrown"))
        {

            if (other.gameObject.name.Contains("thrown"))
            {
                Destroy(other.gameObject);
            }

            spawnSpores();
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {
        currentHP = GetComponent<hpStore>().health;

        if (currentHP <= 0 && !burst)
        {
            burst = true;
            Invoke("spawnSpores", 0.3f);

        }
    }
}
