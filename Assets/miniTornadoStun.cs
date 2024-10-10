using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miniTornadoStun : MonoBehaviour
{

    private playerMovement movementScript;

    // Start is called before the first frame update
    void Start()
    {
        movementScript = GetComponent<playerMovement>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Contains("stun"))
        {
            movementScript.enabled = false;
            Invoke("unStun", 1f);
        }
        else if (other.gameObject.name.Contains("trapPlant"))
        {
            movementScript.enabled = false;
            Invoke("unStun", 1f);

        }
    }

    void unStun()
    {
        movementScript.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
