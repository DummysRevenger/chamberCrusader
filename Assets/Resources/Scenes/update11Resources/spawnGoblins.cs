using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnGoblins : MonoBehaviour
{
    private GameObject goblinPrefab;

    public GameObject cactusGoblin;


    // Start is called before the first frame update
    void Start()
    {
        if (selectCharacter.mapSelected == "desert")
        {
            goblinPrefab = cactusGoblin;
        }

        goblinPrefab = cactusGoblin;

        Invoke("spawnGoblin", 2f);
    }

    void spawnGoblin()
    {
        Instantiate(goblinPrefab, transform.position, transform.rotation);

        Invoke("spawnGoblin", 2f);
    }

    
}
