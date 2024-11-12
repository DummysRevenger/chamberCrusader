using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementSpeedStore : MonoBehaviour
{

    public static playerMovementSpeedStore S;

    public float speed = 5f;

    public float baseMovementSpeed = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        S = this;

        baseMovementSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
