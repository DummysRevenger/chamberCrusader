using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDoDamage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        

        if (collision.gameObject.CompareTag("bullet") && !collision.gameObject.name.Contains("RPG"))
        {
            Destroy(collision.gameObject);
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.clip = playerAudioStore.S.audioClips[1];
            audioSource.Play();
            hpStorePlayer.S.playerHealth -= nextRoomChecker.S.projectileDamage;

            

        }
    }
    // Update is called once per frame
    void Update()
    {
        
        
    }
}
