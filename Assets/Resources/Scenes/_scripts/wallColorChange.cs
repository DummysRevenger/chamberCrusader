using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallColorChange : MonoBehaviour
{
    public int roomNo;
    public Color newColor;

    public System.Random random = new System.Random();



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>(); // Get the SpriteRenderer component attached to the object

        roomNo = nextRoomChecker.S.roomNumber;

        if (roomNo < 11)
        {
            roomNo = nextRoomChecker.S.roomNumber;
            newColor = new Color(((10f-roomNo) * 5f) / 255f + 0.1f, ((10f-roomNo) * 7f) / 255f + 0.1f, ((10f-roomNo) * 7f) / 255f + 0.1f);
            spriteRenderer.color = newColor; // Set the new color on the SpriteRenderer
        }

        if ((roomNo >= 11) && (roomNo < 21))
        {
            roomNo = nextRoomChecker.S.roomNumber;
            newColor = new Color((((23f-roomNo) * 10f)) / 255f, 0f, 0f);
            spriteRenderer.color = newColor; // Set the new color on the SpriteRenderer
        }

        if ((roomNo >= 21) && (roomNo < 31))
        {
            roomNo = nextRoomChecker.S.roomNumber;
            newColor = new Color(0f, (36f - roomNo) * 10f, 0f);
            spriteRenderer.color = newColor; // Set the new color on the SpriteRenderer

            

        }



        if ((roomNo >= 35) && (roomNo < 45))
        {
            roomNo = nextRoomChecker.S.roomNumber;
            newColor = new Color((((roomNo - 34f) * 10f)) / 255f, ((roomNo - 34f) * 10f) / 255f, 0f);
            spriteRenderer.color = newColor; // Set the new color on the SpriteRenderer
        }

        if ((roomNo >= 45) && (roomNo < 55))
        {
            roomNo = nextRoomChecker.S.roomNumber;
            newColor = new Color((((roomNo - 44f) * 10f)) / 255f, ((roomNo - 44f) * 15f) / 255f, 0f);
            spriteRenderer.color = newColor; // Set the new color on the SpriteRenderer
        }

        if ((roomNo >= 55) && (roomNo < 65))
        {
            roomNo = nextRoomChecker.S.roomNumber;
            newColor = new Color(0, ((roomNo - 54f) * 10f) / 255f, 0f);
            spriteRenderer.color = newColor; // Set the new color on the SpriteRenderer
        }

        if ((roomNo >= 65) && (roomNo < 75))
        {
            roomNo = nextRoomChecker.S.roomNumber;
            newColor = new Color(0f, 0f, ((roomNo - 64f) * 10f) / 255f);
            spriteRenderer.color = newColor; // Set the new color on the SpriteRenderer
        }


        if ((roomNo >= 65) && (roomNo < 75))
        {
            roomNo = nextRoomChecker.S.roomNumber;
            newColor = new Color(((roomNo - 64f) * 6f) / 255f, 0f, ((roomNo - 64f) * 11f) / 255f);
            spriteRenderer.color = newColor; // Set the new color on the SpriteRenderer
        }

        if (roomNo >= 75)
        {
            int random1 = nextRoomChecker.S.random1;
            int random3 = nextRoomChecker.S.random2;

            newColor = new Color(random1 / 5f, random1 / 5f , random3 / 5f);
            spriteRenderer.color = newColor; // Set the new color on the SpriteRenderer
        }
    }
}
