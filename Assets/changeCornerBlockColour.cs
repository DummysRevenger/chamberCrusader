using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCornerBlockColour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        

        switch (selectCharacter.mapSelected)
        {
            case "dungeon":
                gameObject.GetComponent<SpriteRenderer>().color = Color.black;
                break;
            case "blood":
                gameObject.GetComponent<SpriteRenderer>().color = new Color(0.3f, 0f, 0f);
                break;

            case "desert":
                gameObject.GetComponent<SpriteRenderer>().color = new Color(71f / 255f, 54f/255f, 0f);
                break;
        }

    }
}
