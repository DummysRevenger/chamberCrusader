using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyColourChanger : MonoBehaviour
{

    private SpriteRenderer spriterenderer;
    Color newColor = new Color(0f, 0f, 0f);
    private int roomNo;

    

    


    // Start is called before the first frame update
    void Start()
    {
        spriterenderer = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        roomNo = nextRoomChecker.S.roomNumber;

        if (roomNo < 11)
        {
            roomNo = nextRoomChecker.S.roomNumber;
            newColor = new Color(((10f - roomNo) * 7f) / 255f + 0.1f, ((10f - roomNo) * 7f) / 255f + 0.1f, ((10f - roomNo) * 7f) / 255f + 0.1f);
            spriterenderer.color = newColor;
        }

        if ((roomNo >= 11) && (roomNo <= 20))
        {
            roomNo = nextRoomChecker.S.roomNumber;
            newColor = new Color((((23f - roomNo) * 25f)) / 255f, 0f, 0f);
            spriterenderer.color = newColor;
            
        }
        

        
    }
}
