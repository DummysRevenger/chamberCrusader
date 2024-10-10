using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireFall : MonoBehaviour
{
    private int endy;

    public GameObject fireFallen;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(fireFallen, gameObject.transform.position, gameObject.transform.rotation);
        }
    }

    void randomEndY()
    {
        endy = (int)Random.Range(-10f, 10f);

        

    }

    void Start()
    {
        randomEndY();
    }

    void FixedUpdate()
    {
        if (transform.position.y <= endy)
        {
            
            Instantiate(fireFallen, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
        }

        transform.position -= new Vector3(0f, Time.deltaTime * 4, 0f);


    }
}
