using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hailFall : MonoBehaviour
{
    public GameObject hailFallen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(hailFallen, gameObject.transform.position, gameObject.transform.rotation);

            

            Destroy(gameObject);
        }

        if (collision.gameObject.name == "hailDestroyer")
        {
            Destroy(gameObject);
        }
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position -= new Vector3(0f, Time.deltaTime*6, 0f);
    }
}
