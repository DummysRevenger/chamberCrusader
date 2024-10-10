using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteFacePlayer : MonoBehaviour
{

    private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.x < transform.position.x)
        {
            transform.rotation =  Quaternion.Euler(0f, -180f, 0f);
        }
        else
        {
            transform.rotation =  Quaternion.Euler(0f, 0f, 0f);
        }
    }
}
