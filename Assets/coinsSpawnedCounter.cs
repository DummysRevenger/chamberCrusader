using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinsSpawnedCounter : MonoBehaviour
{

    public int coinsSpawned = 1;

    public int tailsCount = 0;

    public static coinsSpawnedCounter S;

    public bool rolledHeads = false;

    // Start is called before the first frame update
    void Start()
    {
        coinsSpawned = 1;

        tailsCount = 0;

        S = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
