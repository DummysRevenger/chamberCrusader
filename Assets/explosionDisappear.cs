using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionDisappear : MonoBehaviour
{

    private GameObject boom;

    // Start is called before the first frame update
    void Start()
    {
        Transform childTransform = transform.GetChild(0);

        boom = childTransform.gameObject;


        Invoke("Disable", 0.7f);
        
    }

    void Disable()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
