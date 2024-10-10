using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireWork : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Vector3 mousePosition = Input.mousePosition;
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, transform.position.z - Camera.main.transform.position.z));

        Vector3 aimDirection = (worldMousePosition - transform.position).normalized;

        
            Vector3 randomOffset = Random.insideUnitCircle;

            aimDirection = aimDirection + randomOffset * 0.2f;

            aimDirection.Normalize();
        


        float angle = -90f + Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;

        Quaternion targetRotation = Quaternion.Euler(0f, 0f, angle);



        transform.rotation = targetRotation;


        Rigidbody2D rocketRigidbody = GetComponent<Rigidbody2D>();
        rocketRigidbody.velocity = 18f * aimDirection;

    }


}




