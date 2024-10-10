using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnSludges : MonoBehaviour
{
    private GameObject sludgePrefab;

    public GameObject sandSludge;


    // Start is called before the first frame update
    void Start()
    {
        if (selectCharacter.mapSelected == "desert")
        {
            sludgePrefab = sandSludge;
        }

        sludgePrefab = sandSludge;

        Invoke("spawnSludge", 6f);
    }

    void spawnSludge()
    {
        Instantiate(sludgePrefab, transform.position, transform.rotation);

        Invoke("spawnSludge", 6f);
    }


}
