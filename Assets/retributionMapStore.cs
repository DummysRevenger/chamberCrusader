using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class retributionMapStore : MonoBehaviour
{

    public static retributionMapStore S;

    public string mapType;

    // Start is called before the first frame update
    void Start()
    {
        S = this;
    }

    // Update is called once per frame
    void Update()
    {

        

        if (selectCharacter.mapSelected == "retribution")
        {

            switch (nextRoomChecker.S.roomNumber)
            {
                case 0:
                    mapType = "vestibule";
                    break;
                case 11:
                    mapType = "limbo";
                    break;
                case 21:
                    mapType = "lust";
                    break;
                case 31:
                    mapType = "muddy";
                    break;
                case 41:
                    mapType = "greedy";
                    break;
                case 51:
                    mapType = "angry";
                    break;
                case 61:
                    mapType = "fire";
                    break;
                case 71:
                    mapType = "violence";
                    break;
                case 81:
                    mapType = "dark";
                    break;
                case 91:
                    mapType = "ice";
                    break;

            }

        }

    }
}
