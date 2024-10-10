using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abyssalLaserDamagePlayer : MonoBehaviour
{
    private GameObject player;

    private hpStore bossHealthStore;

    private GameObject abyssalHorrorObject;

    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindWithTag("Player");

        

        abyssalHorrorObject = GameObject.Find("abyssalHorror");

        //bossHealthStore = abyssalHorrorObject.GetComponent<hpStore>();

    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            hpStorePlayer.S.playerHealth -= 70 * Time.deltaTime;

            //bossHealthStore.health += 70 * Time.deltaTime;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
