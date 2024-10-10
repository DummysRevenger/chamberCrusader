using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tipCreatureRunFromPlayer : MonoBehaviour
{
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float distanceFromPlayer = Vector3.Distance(transform.position, player.transform.position);

        if (distanceFromPlayer < 7)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, -5  * Time.deltaTime);
        }
    }
}
