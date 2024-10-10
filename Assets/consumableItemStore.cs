using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class consumableItemStore : MonoBehaviour
{

    public static consumableItemStore S;

    public string itemEquipped;

    private int currentRoom;

    // Start is called before the first frame update
    void Start()
    {
        S = this;

        //itemEquipped = "warmBoots";
    }

    // Update is called once per frame
    void Update()
    {

        if ((Input.GetKeyDown(KeyCode.N) || Input.GetKeyDown(KeyCode.C)))
        {
            switch(itemEquipped)
            {


                case "warmBoots":

                    currentRoom = nextRoomChecker.S.roomNumber;
                    playerHasWarmBootsStore.S.hasWarmBoots = true;
                    itemEquipped = "";

                    Debug.Log("warm boots used");
                    break;
            }
        }

        if (playerHasWarmBootsStore.S.hasWarmBoots)
        {

            int roomDiff = nextRoomChecker.S.roomNumber - currentRoom;

            

            if (roomDiff == 3)
            {
                playerHasWarmBootsStore.S.hasWarmBoots = false;

                currentRoom = 0;
            }

            
        }

    }
}
