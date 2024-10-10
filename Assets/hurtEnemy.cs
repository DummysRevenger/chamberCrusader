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

        

        if (collision.gameObject.CompareTag("enemy") || collision.gameObject.CompareTag("rangedEnemy"))
        {

            Debug.Log(this);
            
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
            else if (gameObject.name == "longSwordHurtBox")
            {
                collision.gameObject.GetComponent<hpStore>().health -= 100;
            }
            else if (gameObject.name == "scytheHurtBox")
            {
                collision.gameObject.GetComponent<hpStore>().health -= 50;
            }
            else if (gameObject.name == "walkingCaneHurtBox")
            {
                collision.gameObject.GetComponent<hpStore>().health -= 50;
            }
            else if (gameObject.name == "prideHurtBoxSwing")
            {
                collision.gameObject.GetComponent<hpStore>().health -= 150;
            }
            else if (gameObject.name == "prideHurtBoxSpin")
            {

                collision.gameObject.GetComponent<hpStore>().health -= 200;
            }
            else if (gameObject.name == "prideHurtBoxThrust")
            {
                collision.gameObject.GetComponent<hpStore>().health -= 100;
            }
            else if (gameObject.name == "spearHurtBox")
            {
                collision.gameObject.GetComponent<hpStore>().health -= 50;

                slothEnergyStore.S.totalEnergy += 5;
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
