using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomColourChanger : MonoBehaviour
{
    public static roomColourChanger S;

    Color newColor = new Color(0f, 0f, 0f);
    public int roomNo;
    public System.Random random = new System.Random();
    public int random1;
    public int random2;

    // Start is called before the first frame update
    void Start()
    {
        S = this;   
    }

    // Update is called once per frame
    void Update()
    {

        

        if (selectCharacter.mapSelected == "dungeon")
        {

            newColor = new Color( 0.3f,0.3f,0.4f);
            Camera.main.backgroundColor = newColor;

        }
        else if (selectCharacter.mapSelected == "blood")
        {
            
            newColor = new Color(135f/255f, 58f/255f, 58f/255f);
            Camera.main.backgroundColor = newColor;

        }
        else if (selectCharacter.mapSelected == "desert")
        {
            
            newColor = new Color( 255f/255f, 230f/255f, 180f/255f);
            Camera.main.backgroundColor = newColor;
        }


        


    }
}
