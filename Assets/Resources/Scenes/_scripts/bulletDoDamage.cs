using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDoDamage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void unFreezeFast()
    {
        playerIsFrozenStore.S.unFreeze();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        

        if (collision.gameObject.CompareTag("bullet") && !collision.gameObject.name.Contains("RPG") && !collision.gameObject.name.Contains("scythe")
            && !collision.gameObject.name.Contains("coinBullet") && !collision.gameObject.name.Contains("player")
            && !collision.gameObject.name.Contains("Fork"))
        {


            Destroy(collision.gameObject);
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.clip = playerAudioStore.S.audioClips[1];
            audioSource.Play();

            if (collision.gameObject.name.Contains("beam"))
            {
                hpStorePlayer.S.playerHealth -= 5f * nextRoomChecker.S.projectileDamage * playerDamageTakenMultiplierStore.damageMultiplier;
            }
            else if (collision.gameObject.name.Contains("beam"))
            {
                hpStorePlayer.S.playerHealth -= 3f * nextRoomChecker.S.projectileDamage * playerDamageTakenMultiplierStore.damageMultiplier;
            }
            else if (collision.gameObject.name.Contains("iceBullet"))
            {
                hpStorePlayer.S.playerHealth -= 2 * nextRoomChecker.S.projectileDamage * playerDamageTakenMultiplierStore.damageMultiplier;

                playerIsFrozenStore.S.freeze();

                Invoke("unFreezeFast", 0.3f);
            }
            else
            {
                hpStorePlayer.S.playerHealth -= nextRoomChecker.S.projectileDamage * playerDamageTakenMultiplierStore.damageMultiplier;
            }

            

        }
    }
    // Update is called once per frame
    void Update()
    {
        
        
    }
}
