using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getCursed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Contains("bloodBullet"))
        {
            increaseDamageTaken();
            Invoke("decreaseDamageTaken", 5f);
        }
    }

    void increaseDamageTaken()
    {
        playerDamageTakenMultiplierStore.damageMultiplier += 0.1f;
    }

    void decreaseDamageTaken()
    {

        playerDamageTakenMultiplierStore.damageMultiplier -= 0.1f;

        if (playerDamageTakenMultiplierStore.damageMultiplier > 1f)
        {
            Invoke("decreaseDamageTaken", 5f);
        }

        if (playerDamageTakenMultiplierStore.damageMultiplier == 1f)
        {
            GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (playerDamageTakenMultiplierStore.damageMultiplier > 1f)
        {
            GetComponent<SpriteRenderer>().color = new Color(1f, 0f, 0f);
        }
        
    }
}
