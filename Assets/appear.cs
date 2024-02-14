using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class appear : MonoBehaviour
{
    public Text text;
    

    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<Text>();
        gameObject.SetActive(false);

        
        
    }

    IEnumerator disappear()
    {
        yield return new WaitForSeconds(5f);
        //text.enabled = false;
        gameObject.SetActive(false);

        


    }


    // Update is called once per frame
    void Update()
    {
        if (room30checker.room30Reached  && gameObject.name.Contains("Ninja"))
        {
            text.enabled = true;
            
            StartCoroutine(disappear());
            
        }
        if (room30checker.bloodRoom30Reached && !gameObject.name.Contains("Ninja"))
        {
            text.enabled = true;
            
            StartCoroutine(disappear());
        }
        if (room20checker.room20Reached && !gameObject.name.Contains("Blood"))
        {
            text.enabled = true;

            
            
            StartCoroutine(disappear());
        }
        if (room20checker.bloodRoom20Reached && !gameObject.name.Contains("Blood"))
        {
            text.enabled = true;

            
            
            StartCoroutine(disappear());
        }

        if (blueBunnyUnlockStore.bunnyUnlocked && gameObject.name.Contains("bunny"))
        {
            text.enabled = true;

            StartCoroutine(disappear());
        }


    }
}
