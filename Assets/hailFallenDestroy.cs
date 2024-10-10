using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hailFallenDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("timedDestruction", 0.7f);
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
