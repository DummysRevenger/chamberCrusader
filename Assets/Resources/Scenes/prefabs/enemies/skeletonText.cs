using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skeletonText : MonoBehaviour
{
    public bool textOn = false;
    public Text theStatement;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        textOn = true;

    }

    void OnTriggerExit2D(Collider2D collision)
    {
        textOn = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (textOn)
        {

        }
        else
        {

        }
    }
}
