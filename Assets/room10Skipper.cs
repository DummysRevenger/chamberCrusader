using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room10Skipper : MonoBehaviour
{
    public bool skipped = false;
    public GameObject skipTo10;
    public static bool room10reached = false;

    // Start is called before the first frame update
    
    void Start()
    {
        if (room10reached && nextRoomChecker.S.roomNumber == 0)
        {
            skipTo10.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (nextRoomChecker.S.roomNumber == 10 && !skipped)
        {
            room10reached = true;

            Debug.Log("room 10 reached!");
        }

        if(Input.GetKey(KeyCode.B) && !skipped && room10reached)
        {
            skipped = true;
            nextRoomChecker.S.roomNumber = 10;
            skipTo10.SetActive(false);
        }



    }
}
