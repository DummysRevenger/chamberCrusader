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
        if (other.gameObject.CompareTag("bullet"))
        {

            if(!other.gameObject.name.Contains("RPG"))
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
