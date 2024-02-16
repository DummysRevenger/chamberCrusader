using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletHurtEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    

    private void OnTriggerEnter2D(Collider2D collision)
    {

        


        if (collision.gameObject.CompareTag("enemy") || collision.gameObject.CompareTag("rangedEnemy"))
        {
            if (!gameObject.name.Contains("RPG") && !gameObject.name.Contains("explosion") && !gameObject.name.Contains("thrown"))
            {
                collision.gameObject.GetComponent<hpStore>().health -= 50;

                transform.position = new Vector2(999f, 999f);

                AudioSource audioSource = GetComponent<AudioSource>();
                audioSource.clip = playerAudioStore.S.audioClips[1];
                audioSource.Play();


                Invoke("destroy", 0.5f);

                
            }
            else if(gameObject.name.Contains("thrown"))
            {
                collision.gameObject.GetComponent<hpStore>().health -= 100;
            }
            else if (gameObject.name.Contains("RPG") || gameObject.name.Contains("explosion"))
            {
                
                collision.gameObject.GetComponent<hpStore>().health -= 300;
            }


        }
    

    }

    public void destroy()
    {
        Destroy(gameObject);
    }
    
}
