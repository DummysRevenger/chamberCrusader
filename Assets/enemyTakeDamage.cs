using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class enemyTakeDamage : MonoBehaviour
{

    public UnityEvent OnBegin, OnDone;

    public Rigidbody2D rb2d;

    
        
    

    private IEnumerator Reset()
    {
        yield return new WaitForSeconds(0.15f);
        rb2d.velocity = Vector3.zero;
        OnDone?.Invoke();

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("playerBullet") || collision.gameObject.CompareTag("sword") || collision.gameObject.CompareTag("boom") )
        {
            


            if (!gameObject.name.Contains("spider"))
            {
                StopAllCoroutines();
                OnBegin?.Invoke();

                

                Vector2 direction = (transform.position - collision.gameObject.transform.position).normalized;

                if (collision.gameObject.CompareTag("bullet"))
                {
                    Debug.Log("come on mate");
                    direction = ((Vector2)transform.position - (Vector2)collision.gameObject.GetComponent<Rigidbody2D>().velocity).normalized;
                }



                rb2d.AddForce(direction * 7f, ForceMode2D.Impulse);

                StartCoroutine(Reset());
            }


            if (collision.gameObject.name.Contains("playerBullet"))
                {


                gameObject.GetComponent<hpStore>().health -= 50;
            }
            else if( collision.gameObject.name.Contains("sword"))
            {
                gameObject.GetComponent<hpStore>().health -= 65;

                

            }
            else if (collision.gameObject.name.Contains("knife"))
            {
                gameObject.GetComponent<hpStore>().health -= 18;
            }
            else if (collision.gameObject.name.Contains("katana"))
            {
                gameObject.GetComponent<hpStore>().health -= 25;
            }

            else if (collision.gameObject.CompareTag("boom"))
            {
                gameObject.GetComponent<hpStore>().health -= 150;
            }
            else if (collision.gameObject.name.Contains("axe"))
            {
                gameObject.GetComponent<hpStore>().health -= 115;
            }





        }
    }

    /*if (collision.gameObject.CompareTag("enemy"))
        {
            if (!gameObject.name.Contains("RPG") && !gameObject.name.Contains("explosion"))
            {
                collision.gameObject.GetComponent<hpStore>().health -= 1;

                transform.position = new Vector2(999f, 999f);

    AudioSource audioSource = GetComponent<AudioSource>();
    audioSource.clip = playerAudioStore.S.audioClips[1];
                audioSource.Play();

               

                Invoke("destroy", 0.5f);


}
            else
{

    collision.gameObject.GetComponent<hpStore>().health -= 300;
}


        }
    // Update is called once per frame
    void Update()
    {
        
    }
    */ 
}
