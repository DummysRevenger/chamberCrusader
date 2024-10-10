using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Get the mouse position in screen space
        Vector3 mousePosition = Input.mousePosition;

        // Convert the mouse position to world space
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, transform.position.z - Camera.main.transform.position.z));

        // Calculate the direction vector from the sprite to the mouse position
        Vector3 direction = worldMousePosition - transform.position;

        // Calculate the angle in degrees
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Apply the rotation to the sprite
        transform.rotation = Quaternion.AngleAxis(angle + 90f, Vector3.forward);


    }
}
