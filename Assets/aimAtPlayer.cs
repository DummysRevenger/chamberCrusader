using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aimAtPlayer : MonoBehaviour
{


    private GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        // Calculate the direction vector from the sprite to the mouse position
        Vector3 direction = player.transform.position - transform.position;

        // Calculate the angle in degrees
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Apply the rotation to the sprite
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
