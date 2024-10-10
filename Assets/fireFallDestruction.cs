using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireFallDestruction : MonoBehaviour
{
    void Start()
    {
        Invoke("timedDestruction", 0.5f);
    }

    void timedDestruction()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
