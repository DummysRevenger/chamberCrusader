
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnOnBurning : MonoBehaviour
{

    private continuousBurning burningScript;

    // Start is called before the first frame update
    void Start()
    {
        burningScript = GetComponent<continuousBurning>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (retributionMapStore.S.mapType == "fire")
        {
            burningScript.enabled = true;
        }

    }
}
