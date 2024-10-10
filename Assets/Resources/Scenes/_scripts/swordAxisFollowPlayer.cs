using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordAxisFollowPlayer : MonoBehaviour
{
    private GameObject player;
    


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }


    // Update is called once per frame
    void FixedUpdate()
    {

        player = GameObject.FindGameObjectWithTag("Player");

        if (player != null)
        {
            transform.position = player.transform.position;
        }
    }
}
