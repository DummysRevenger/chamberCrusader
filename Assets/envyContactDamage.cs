using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class envyContactDamage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemy") || collision.gameObject.CompareTag("rangedEnemy"))
        {
            if (collision.gameObject.GetComponent<hpStore>() != null)
            {
                if (envyStealAttackAbility.S.contactAbilityRunning)
                {
                    collision.gameObject.GetComponent<hpStore>().health -= 100 * Time.deltaTime;
                }

                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
