using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammoGetPickedUp : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") || other.gameObject.name == "grabberIncreasedRange")
        {
            switch(playerSwitcher.S.playerType)
            {
                case "knight":
                    ammoStore.S.playerAmmo += 5;
                    statsStore.ammo += 5;
                    break;
                case "ninja":
                    ammoStore.S.playerAmmo += 3;
                    statsStore.ammo += 3;
                    break;
                case "soldier":
                    ammoStore.S.playerAmmo += 1;
                    statsStore.ammo++;
                    break;

            }

            

            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.Play();
            transform.position = new Vector2(99f, 99f);
            Invoke("destroy", 1f);
        }
    }
    
    void destroy()
    {
        Destroy(gameObject);
    }
}
