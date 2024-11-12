using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinGoToMagnet : MonoBehaviour
{
    private GameObject player;
    private float moveSpeed = 4f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (magnetiseGold.magnetFound)
        {
            // Calculate the direction towards the player
            Vector3 direction = (player.transform.position - transform.position).normalized;

            // Move the object towards the player
            transform.Translate(direction * moveSpeed * Time.deltaTime);
        }
    }
}
