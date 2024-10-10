using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnViperFish : MonoBehaviour
{

    public GameObject spawnPrefab;



    // Start is called before the first frame update
    void Start()
    {
        Invoke("spawn", 10f);
    }

    void spawn()
    {
        Quaternion desiredRotation = Quaternion.Euler(0, 0, 0);

        Instantiate(spawnPrefab, transform.position, desiredRotation);

        Invoke("spawn", 20f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
