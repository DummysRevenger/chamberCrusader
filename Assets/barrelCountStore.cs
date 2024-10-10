using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelCountStore : MonoBehaviour
{

    public static float barrelCount = 1;

    // Start is called before the first frame update
    void Start()
    {
        barrelCount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (barrelCount > 3)
        {
            barrelCount = 3;
        }
    }
}
