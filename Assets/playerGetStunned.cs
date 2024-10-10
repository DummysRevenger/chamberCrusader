using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerGetStunned : MonoBehaviour
{

    private playerMovement movementScript;

    // Start is called before the first frame update
    void Start()
    {
        movementScript = GetComponent<playerMovement>();
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name.Contains("stun") || other.gameObject.name.Contains("Tornado"))
        {
            movementScript.enabled = false;
            
        }


        if (other.gameObject.name.Contains("stun"))
        {
            Invoke("unStun", 1f);
        }
        else if (other.gameObject.name.Contains("Tornado"))
        {
            Invoke("unStun", 2.5f);
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
