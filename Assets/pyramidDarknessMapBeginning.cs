using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pyramidDarknessMapBeginning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("disable", 1f);
    }

    void disable()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
