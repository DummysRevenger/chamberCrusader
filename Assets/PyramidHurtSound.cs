using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyramidHurtSound : MonoBehaviour
{

    private GameObject hurtSoundStore;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        /*if (other.gameObject.name.Contains("shield") || other.gameObject.name.Contains("playerBullet") || other.gameObject.CompareTag("sword") || other.gameObject.CompareTag("boom") || other.gameObject.name.Contains("thrown"))
        {
            if (pyramidTransition.stage5Begun)
            {
                hurtSoundStore.GetComponent<AudioSource>().Play();
            }
        }*/
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
