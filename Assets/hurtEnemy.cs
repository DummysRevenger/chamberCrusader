using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurtEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            if (gameObject.name == "swordHurtBox")
            {
                collision.gameObject.GetComponent<hpStore>().health -= 65;
            }
            else if (gameObject.name == "katanaHurtBox")
            {
                collision.gameObject.GetComponent<hpStore>().health -= 25;
            }
            else if (gameObject.name == "knifeHurtBox")
            {
                collision.gameObject.GetComponent<hpStore>().health -= 18;
            }

            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.Play();
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
