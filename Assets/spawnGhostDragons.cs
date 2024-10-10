using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnGhostDragons : MonoBehaviour
{
    private GameObject dragonPrefab;

    public GameObject dragon;



    // Start is called before the first frame update
    void Start()
    {
        


        Invoke("spawnDragon", 12f);
    }



    void spawnDragon()
    {
        Instantiate(dragon, transform.position, transform.rotation);

        Invoke("spawnDragon", 12f);
    }


}
