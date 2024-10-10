using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thrombusDisableAbilities : MonoBehaviour
{


    public GameObject crossUI;


    public bool disableAbilities = true;

    public static thrombusDisableAbilities S;


    // Start is called before the first frame update
    void Start()
    {

        S = this;

        disableAbilities = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (nextRoomChecker.S.roomNumber == 20 && selectCharacter.mapSelected == "blood")
        {
            disableAbilities = true;
            crossUI.SetActive(true);
        }
        else if (nextRoomChecker.S.roomNumber == 21 && selectCharacter.mapSelected == "blood")
        {
            disableAbilities = false;
            crossUI.SetActive(false);
        }
    }
}
