using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyProjectile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("bullet") && !other.gameObject.name.Contains("scytheRay") && !other.gameObject.name.Contains("coinBullet"))
        {

            if(!other.gameObject.name.Contains("Wrath") && !other.gameObject.name.Contains("bloodBullet") && !other.gameObject.name.Contains("RPG") && !other.gameObject.name.Contains("beam") && !other.gameObject.name.Contains("stun"))
            {
                Destroy(other.gameObject);
            }
            else
            {

            }

            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
