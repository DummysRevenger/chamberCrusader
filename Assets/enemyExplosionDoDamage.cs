using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyExplosionDoDamage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("enemyBoom"))
        {
            GetComponent<hpStorePlayer>().playerHealth -= 150;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
