using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomEventsBackGroundChanger : MonoBehaviour
{

    private SpriteRenderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        switch(selectCharacter.mapSelected)
        {
            case "dungeon":
                renderer.color = new Color(0f, 0f, 0f);
                break;
            case "desert":
                renderer.color = new Color(203f/255f, 189f/255f, 147f/255f);
                break;
            case "blood":
                renderer.color = new Color(0.3f, 0f, 0f);
                break;
            case "onion":
                renderer.color = new Color(129f/255f, 133f/255f, 137f/255f);
                break;
            case "retribution":
                renderer.color = new Color(0f, 0f, 0f);
                break;
        }
    }
}
