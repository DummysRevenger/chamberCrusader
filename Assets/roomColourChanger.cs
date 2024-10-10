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
        else if (selectCharacter.mapSelected == "desert" && !pyramidTransition.stage3bool)
        {
            
            newColor = new Color( 255f/255f, 230f/255f, 180f/255f);
            Camera.main.backgroundColor = newColor;
        }
        else if (selectCharacter.mapSelected == "onion")
        {
            newColor = new Color(0.3f, 0.3f, 0.3f);
            Camera.main.backgroundColor = newColor;
        }
        else if (selectCharacter.mapSelected == "retribution")
        {
            switch (nextRoomChecker.S.roomNumber)
            {
                case 0: // vestibule
                    Camera.main.backgroundColor = new Color(0.6f, 0.3f, 0f);
                    break;
                case 11: // limbo
                    Camera.main.backgroundColor = new Color(150f / 255f, 75f / 255f, 0f);
                    break;
                case 21: // lust
                    Camera.main.backgroundColor = new Color(50f / 255f, 50f / 255f, 50f / 255f);
                    break;
                case 31: // muddy
                    Camera.main.backgroundColor = new Color(75f / 255f, 35f / 255f, 0f);
                    break;
                case 41: // greedy
                    Camera.main.backgroundColor = new Color(100 / 255f, 75 / 255f, 0f);
                    break;
                case 51: // angry
                    Camera.main.backgroundColor = new Color(0f / 255f, 100f / 255f, 0f);
                    break;
                case 61: // fire
                    Camera.main.backgroundColor = new Color(100 / 255f, 15 / 255f, 0f);
                    break;
                case 71: // violence
                    newColor = new Color(135f / 255f, 58f / 255f, 58f / 255f);
                    break;
                case 81: // dark
                    Camera.main.backgroundColor = new Color(60f/255f, 0f, 60/255f);
                    break;
                case 91: // ice
                    Camera.main.backgroundColor = new Color(200f / 255f, 255f / 255f, 255f / 255f);
                    break;

            }
        }

        


    }
}
