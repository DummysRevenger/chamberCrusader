using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLaserDoDamage : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerStay2D(Collider2D other)
    {

        

        if (other.gameObject.CompareTag("enemy") ||
            other.gameObject.CompareTag("rangedEnemy"))
        {



            if (other.gameObject.GetComponent<hpStore>() != null)
            {
                other.gameObject.GetComponent<hpStore>().health -= 200 * Time.deltaTime;

                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
