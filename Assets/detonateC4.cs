using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class detonateC4 : MonoBehaviour
{

    public GameObject explosion;

    public bool bombPlaced = false;

    public GameObject cross3;


    void Start()
    {
        cross3 = GameObject.Find("crossUI3");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.G) && hpStorePlayer.S.playerHealth > 0)
        {

            if (!bombPlaced)
            {
                Instantiate(explosion, transform.position, Quaternion.identity);
                bombPlaced = true;
                Destroy(gameObject);

                cross3.GetComponent<Image>().enabled = true;
            }

        }
        
        


    }
}
