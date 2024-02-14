using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBlueBunny : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {

        transform.position += new Vector3(3f,0f,0f) * Time.deltaTime;

        if (transform.position.x > 12f)
        {
            Destroy(gameObject);
        }

    }
}
