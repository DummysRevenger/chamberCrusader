using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changePauseMenuBackground : MonoBehaviour
{

    private Sprite dungeonBackground;
    private Sprite onionCityBackground;
    private Sprite onionInfectionBackground;
    private Sprite bloodBackground;
    private Sprite desertBackground;

    private Sprite tipBookBackground;


    // Start is called before the first frame update
    void Start()
    {
        dungeonBackground = Resources.Load<Sprite>("Scenes/update12Resources/pauseMenu/dungeonPauseBGWide");

        onionInfectionBackground = Resources.Load<Sprite>("Scenes/update12Resources/pauseMenu/onionZombiePauseBGWide");

        onionCityBackground = Resources.Load<Sprite>("Scenes/update12Resources/pauseMenu/onionCityPauseBGWide");

        bloodBackground = Resources.Load<Sprite>("Scenes/update12Resources/pauseMenu/bloodPauseBGWide");

        desertBackground = Resources.Load<Sprite>("Scenes/update12Resources/pauseMenu/desertPauseBGWide");

        tipBookBackground = Resources.Load<Sprite>("Scenes/update12Resources/pauseMenu/tipBookBGWide");
    }

    // Update is called once per frame
    void Update()
    {

        

        

        switch(selectCharacter.mapSelected)
        {
            case "dungeon":
                GetComponent<Image>().sprite = dungeonBackground;
                break;
            case "blood":
                GetComponent<Image>().sprite = bloodBackground;
                break;
            case "onion":

                if (nextRoomChecker.S.roomNumber <= 15)
                {
                    GetComponent<Image>().sprite = onionCityBackground;
                }
                else
                {
                    GetComponent<Image>().sprite = onionInfectionBackground;
                }
                break;
            case "desert":
                GetComponent<Image>().sprite = dungeonBackground;
                break;
        }
    }
}
