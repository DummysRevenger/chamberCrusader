using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sporeExplode : MonoBehaviour
{

    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void burst()
    {
        Instantiate(explosion, transform.position, transform.rotation);
        GetComponent<hpStore>().health = 0;
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            burst();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
