using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vestibularWindBlowPlayer : MonoBehaviour
{

    private float windForce = 0.05f; // Adjust this value to control the strength of the wind
    private Rigidbody2D playerRigidbody;

    private GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        playerRigidbody = player.GetComponent<Rigidbody2D>();
    }

    private void ApplyWindForce()
    {
        // Get the player's current velocity
        Vector2 currentVelocity = playerRigidbody.velocity;

        // Apply the wind force to the horizontal velocity
        currentVelocity.x += windForce;

        // Set the updated velocity back on the Rigidbody2D
        playerRigidbody.velocity = currentVelocity;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (retributionMapStore.S.mapType == "vestibule")
        {
            ApplyWindForce();
        }
    }
}
