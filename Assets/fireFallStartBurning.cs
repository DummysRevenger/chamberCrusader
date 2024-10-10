using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireFallStartBurning : MonoBehaviour
{
    public GameObject burningObject;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("beginBurning", 0.48f);
    }

    void beginBurning()
    {
        Instantiate(burningObject, transform.position, transform.rotation);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
