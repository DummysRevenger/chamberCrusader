using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torchColourChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (selectCharacter.mapSelected == "blood")
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(133f / 255f, 0f, 0f);
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
        }
    }
}
