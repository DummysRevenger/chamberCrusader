using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vestibularWindBlowPlayerBullet : MonoBehaviour
{

    private float windForce = 0.1f; // Adjust this value to control the strength of the wind
    private Rigidbody2D bulletRigidbody;

    

    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody2D>();
    }

    private void ApplyWindForce()
    {
        // Get the player's current velocity
        Vector2 currentVelocity = bulletRigidbody.velocity;

        // Apply the wind force to the horizontal velocity
        currentVelocity.x += windForce;

        // Set the updated velocity back on the Rigidbody2D
        bulletRigidbody.velocity = currentVelocity;
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
