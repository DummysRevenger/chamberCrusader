using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thrombusSpawnDragon : MonoBehaviour
{

    public GameObject dragon;


    

    void spawnDragon()
    {
        Instantiate(dragon, transform.position, transform.rotation);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Contains("thrown") || other.gameObject.CompareTag("boom"))
        {
            Invoke("spawnDragon", 0.2f);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
