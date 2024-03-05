using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class findCollisionWithWall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("ffs");

        if (collision.gameObject.CompareTag("metawall"))
        {
            Debug.Log("colliding with wall");

            
        }



    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
