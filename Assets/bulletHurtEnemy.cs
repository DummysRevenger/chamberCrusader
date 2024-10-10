using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletHurtEnemy : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject bloodGoblin;

    public GameObject playerFly;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemy") || collision.gameObject.CompareTag("rangedEnemy"))
        {
            if (gameObject.name.Contains("playerCrocodileBullet"))
            {

                Debug.Log("chomp chomp");
                collision.gameObject.GetComponent<hpStore>().health -= 200 * Time.deltaTime;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if ((collision.gameObject.CompareTag("enemy") || collision.gameObject.CompareTag("rangedEnemy")) && !gameObject.name.Contains("playerCrocodileBullet"))
        {

            
            if (gameObject.name.Contains("coinBulletSmall")
                || gameObject.name.Contains("flyBullet"))
            {
                collision.gameObject.GetComponent<hpStore>().health -= 25;


                if (gameObject.name.Contains("flyBullet"))
                {

                    Debug.Log("wtf");
                    Instantiate(playerFly, transform.position, transform.rotation);
                }

                transform.position = new Vector2(999f, 999f);
                Invoke("destroy", 0.5f);
            }
            else if (gameObject.name.Contains("coinBulletBig")
                || gameObject.name.Contains("superBullet"))
            {
                collision.gameObject.GetComponent<hpStore>().health -= 100;
                transform.position = new Vector2(999f, 999f);
                Invoke("destroy", 0.5f);
            }
            else if (gameObject.name.Contains("GhostBulletEx"))
            {
                collision.gameObject.GetComponent<hpStore>().health -= 75;
            }
            else if (gameObject.name.Contains("GhostBullet"))
            {
                collision.gameObject.GetComponent<hpStore>().health -= 40;
            }
            else if (!gameObject.name.Contains("RPG") && !gameObject.name.Contains("explosion") && !gameObject.name.Contains("thrown"))
            {
                if (!collision.gameObject.name.Contains("thrombus") && !collision.gameObject.name.Contains("anubis") &&
                    !collision.name.Contains("thePlant"))
                {


                    if (collision.gameObject.GetComponent<hpStore>() != null)
                    {
                        collision.gameObject.GetComponent<hpStore>().health -= 50;
                    }


                    transform.position = new Vector2(999f, 999f);
                    AudioSource audioSource = GetComponent<AudioSource>();
                    audioSource.clip = playerAudioStore.S.audioClips[1];
                    audioSource.Play();
                    Invoke("destroy", 0.5f);
                }
                else
                {
                    collision.gameObject.GetComponent<hpStore>().health -= 10;
                    transform.position = new Vector2(999f, 999f);

                    AudioSource audioSource = GetComponent<AudioSource>();
                    audioSource.clip = playerAudioStore.S.audioClips[1];
                    audioSource.Play();
                    Invoke("destroy", 0.5f);
                }
                

                
                

                
            }
            else if(gameObject.name.Contains("thrown"))
            {

                
                if (!collision.gameObject.name.Contains("thrombus") && !collision.gameObject.name.Contains("anubis") &&
                    !collision.name.Contains("thePlant"))
                {
                    collision.gameObject.GetComponent<hpStore>().health -= 100;
                }
                else if (collision.gameObject.name.Contains("anubis"))
                {
                    Debug.Log("no damage taken");
                }
                else
                {
                    collision.gameObject.GetComponent<hpStore>().health -= 25;
                }


            }
            else if (gameObject.name.Contains("RPG") || gameObject.name.Contains("explosion"))
            {


                if (!collision.gameObject.name.Contains("thrombus") && !collision.gameObject.name.Contains("Snake") &&
                    !collision.name.Contains("thePlant"))
                {
                    collision.gameObject.GetComponent<hpStore>().health -= 150;
                }
                else
                {
                    collision.gameObject.GetComponent<hpStore>().health -= 50;
                }
            }


        }
    

    }

    public void destroy()
    {
        
        
        Destroy(gameObject);
    }
    
}
