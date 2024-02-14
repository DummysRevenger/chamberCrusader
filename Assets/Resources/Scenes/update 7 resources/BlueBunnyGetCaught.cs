using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBunnyGetCaught : MonoBehaviour
{
    public static BlueBunnyGetCaught S;

    


    void Start()
    {
        S = this;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            blueBunnyUnlockStore.bunnyUnlocked = true;

            Destroy(gameObject);

        }
    }
}
