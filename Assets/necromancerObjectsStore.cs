using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class necromancerObjectsStore : MonoBehaviour
{

    public static necromancerObjectsStore S;


    public GameObject rightSpawner;

    public GameObject leftSpawner;

    public GameObject upSpawner;

    public GameObject globalLight;

    public GameObject spotLight;

    public GameObject necromancerBackground;

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
