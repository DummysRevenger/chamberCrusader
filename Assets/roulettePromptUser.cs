using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class roulettePromptUser : MonoBehaviour
{

    private GameObject thePrompt;

    // Start is called before the first frame update
    void Start()
    {
        thePrompt = GameObject.Find("roulettePrompt");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            thePrompt.GetComponent<Text>().enabled = true;

        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            thePrompt.GetComponent<Text>().enabled = false;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
