using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBurningDestruction : MonoBehaviour
{
    void Start()
    {
        Invoke("timedDestruction", 2.5f);
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
