using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateRoom : MonoBehaviour
{
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "room")
        {
            text.text = "Rooms:" + nextRoomChecker.S.roomNumber;
        }
        else
        {
            text.text = "Final Rooms:" + nextRoomChecker.S.roomNumber;
        }
    }
}
