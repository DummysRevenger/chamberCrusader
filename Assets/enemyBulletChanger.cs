using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBulletChanger : MonoBehaviour
{
    public int roomNo;
    public Color newColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>(); // Get the SpriteRenderer component attached to the object

        roomNo = nextRoomChecker.S.roomNumber;

        

        if ((roomNo >= 35) && (roomNo < 45))
        {
            roomNo = nextRoomChecker.S.roomNumber;
            newColor = new Color(0f, 0f, 255f);
            spriteRenderer.color = newColor; // Set the new color on the SpriteRenderer
        }

        

    }
}
