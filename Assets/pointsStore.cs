using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointsStore : MonoBehaviour
{
    public int points = 0;

    public static pointsStore S;

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
