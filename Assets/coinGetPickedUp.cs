using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinGetPickedUp : MonoBehaviour
{


    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        

        if (other.gameObject.CompareTag("Player") || other.gameObject.name == "grabberIncreasedRange")
        {
            transform.position = new Vector3(999f, 999f, 0f);

            

            

            incrementCount();

            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.Play();
            transform.position = new Vector2(99f, 99f);
            Invoke("delete", 1f);
        }
    }

    void delete()
    {
        Destroy(gameObject);
    }

    void incrementCount()
    {
        switch(gameObject.name)
        {
            case "goldCoin(Clone)":
                coinCounterStore.coinNumber++;
                coinCounterStore.roundCoinNumber++;
                break;

            case "smallBankNote(Clone)":
                coinCounterStore.coinNumber += 10;
                coinCounterStore.roundCoinNumber += 10;
                break;

            case "bigBankNote(Clone)":
                coinCounterStore.coinNumber += 100;
                coinCounterStore.roundCoinNumber += 100;
                break;

            case "goldBar(Clone)":
                coinCounterStore.coinNumber += 500;
                coinCounterStore.roundCoinNumber += 500;
                break;

        }

            
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
