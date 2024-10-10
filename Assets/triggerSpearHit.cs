using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerSpearHit : MonoBehaviour
{

    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("enemy"))
        {
            audioSource.Play();
        }    

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
