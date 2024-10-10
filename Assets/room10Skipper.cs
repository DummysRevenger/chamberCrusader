using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room10Skipper : MonoBehaviour
{
    public static bool skipped = false;
    public GameObject skipTo10;
    public static bool room10reached = false;

    public GameObject middleSpawner;

    // Start is called before the first frame update
    
    void Start()
    {
        skipped = false;


        Invoke("showText", 1f);

        
        

        

    }

    void showText()
    {
        if (room10reached && nextRoomChecker.S.roomNumber == 0)
        {

            skipTo10.SetActive(true);

        }
        else
        {
            skipTo10.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

        middleSpawner = GameObject.Find("middleMiddleSpawner");


        if (nextRoomChecker.S.roomNumber == 10 && !skipped)
        {
            room10reached = true;
        }
        

        if(Input.GetKey(KeyCode.B) && !skipped && room10reached && nextRoomChecker.S.roomNumber == 0)
        {

            coinCounterStore.roundCoinNumber += 1000;

            skipped = true;
            nextRoomChecker.S.roomNumber = 10;

            statsStore.roomsSkipped += 10;

            middleSpawner.GetComponent<blockSpawner>().spawnRoulette();

            skipTo10.SetActive(false);
        }
        else if(nextRoomChecker.S.roomNumber != 0 && !skipped)
        {
            

            skipped = false;
            skipTo10.SetActive(false);
        }



    }
}
