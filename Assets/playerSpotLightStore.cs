using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSpotLightStore : MonoBehaviour
{

    public static playerSpotLightStore S;

    public GameObject spotLight;

    public GameObject pyramidDarknessMap;

    // Start is called before the first frame update
    void Start()
    {
        S = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
