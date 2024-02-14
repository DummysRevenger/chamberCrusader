using UnityEngine;

public class spikeDoDamage : MonoBehaviour
{
    private int damageAmount = 2;

    private void OnTriggerStay2D(Collider2D collision)
    {
        // Check if the colliding object is the player
        if (collision.CompareTag("Player"))
        {
            
            hpStorePlayer.S.playerHealth -= damageAmount;

            
        }
    }
}