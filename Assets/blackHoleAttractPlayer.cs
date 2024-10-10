using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackHoleAttractPlayer : MonoBehaviour
{

    private GameObject player;

    private Vector3 playerVector;

    private float distanceFromPlayer;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        playerVector = Vector3.MoveTowards(player.transform.position, transform.position, Time.deltaTime / 2);

        player.transform.position = playerVector;


        // deal damage to the player
        distanceFromPlayer = Vector3.Distance(player.transform.position, transform.position);


        if (distanceFromPlayer < 5f)
        {
            if ((20f * Time.deltaTime / distanceFromPlayer) < 3f)
            {
                hpStorePlayer.S.playerHealth -= 5f * Time.deltaTime / distanceFromPlayer;
            }
            else
            {
                hpStorePlayer.S.playerHealth -= 500f * Time.deltaTime;
            }

            
        }


    }
}
