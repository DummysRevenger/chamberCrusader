using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class continuousBurning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (hpStorePlayer.S.playerHealth != null)
        {
            hpStorePlayer.S.playerHealth -= 5 * Time.deltaTime;
        }
    }
}
