using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowPlayerOnContact : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            playerIsMuddedStore.S.Mud();
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerIsMuddedStore.S.Mud();
        }
    }

    


    // Update is called once per frame
    void Update()
    {
        
    }
}
