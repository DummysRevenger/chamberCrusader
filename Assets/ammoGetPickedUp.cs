using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammoGetPickedUp : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            switch(playerSwitcher.S.playerType)
            {
                case "knight":
                    ammoStore.S.playerAmmo += 5;
                    break;
                case "ninja":
                    ammoStore.S.playerAmmo += 3;
                    break;
                case "soldier":
                    ammoStore.S.playerAmmo += 1;
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
