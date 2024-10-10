using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wrathBulletHealPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            hpStorePlayer.S.playerHealth += 40;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
