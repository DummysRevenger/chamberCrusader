using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getStunned : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "shield")
        {

            Debug.Log("hit by shield");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
