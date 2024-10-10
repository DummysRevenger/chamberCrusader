using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textChangeColor : MonoBehaviour
{

    public Text theText;

    // Start is called before the first frame update
    void Start()
    {
        theText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {


        if (selectCharacter.mapSelected == "dungeon")
        {
            
            theText.color = Color.red;
            
        }
        else if (selectCharacter.mapSelected == "blood")
        {
            theText.color = Color.blue;
        }
        else if (selectCharacter.mapSelected == "desert")
        {
            theText.color = Color.black;
        }
        else if (selectCharacter.mapSelected == "retribution" && (retributionMapStore.S.mapType == "fire" || retributionMapStore.S.mapType == "violence"))
        {
            theText.color = Color.blue;
        }
    }
}
