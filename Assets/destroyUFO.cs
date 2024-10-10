using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyUFO : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (hpStore.pyramidDown)
        {

            

            Destroy(gameObject);
        }
    }
}
