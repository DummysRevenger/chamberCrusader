using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lustBombExplode : MonoBehaviour
{

    public GameObject lustExplosionPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("explode", 3f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            Instantiate(lustExplosionPrefab, transform.position, transform.rotation);

            Destroy(gameObject);

            CancelInvoke("explode");
        }
    }

    void explode()
    {
        Instantiate(lustExplosionPrefab, transform.position, transform.rotation);

        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
