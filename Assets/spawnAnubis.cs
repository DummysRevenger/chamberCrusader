using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnAnubis : MonoBehaviour
{
    public GameObject Anubis;


    // Start is called before the first frame update
    void Start()
    {

        Invoke("spawnNoob", 15f);
    }

    void spawnNoob()
    {
        Instantiate(Anubis, transform.position, transform.rotation);

        Invoke("spawnNoob", 15f);
    }


}
