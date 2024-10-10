using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomEventsTrigger : MonoBehaviour
{

    public GameObject fightingScene;

    public bool roll;

    public GameObject randomEventObject;

    public static randomEventsTrigger S;

    public GameObject randomBackground;

    public GameObject coin;

    public GameObject dice;

    public GameObject dice3;

    public GameObject wishBone;

    public GameObject cards;

    public GameObject theCanvas;

    public GameObject[] enemies;



    // Start is called before the first frame update
    void Start()
    {
        S = this;   
    }

    // Update is called once per frame
    void Update()
    {
        if (nextRoomChecker.S.roomNumber % 10 == 0 && !nextRoomChecker.S.rollDone)
        {

            


            fightingScene.SetActive(false);

            randomEventObject.SetActive(true);

            randomBackground.SetActive(true);

            theCanvas.SetActive(false);

            

            // Find all GameObjects with the tag "eemy"
            //enemies = GameObject.FindGameObjectsWithTag("enemy");

            /* Loop through each enemy and disable it
            foreach (GameObject enemy in enemies)
            {
                enemy.SetActive(false);
            }*/

            switch(selectCharacter.mapSelected)
            {
                case "dungeon":
                    dice.SetActive(true);
                    break;
                case "blood":
                    wishBone.SetActive(true);
                    break;
                case "onion":
                    coin.SetActive(true);
                    break;
                case "desert":
                    cards.SetActive(true);
                    break;
                case "retribution":
                    dice3.SetActive(true);
                    break;
            }

        }
        else
        {


            


            fightingScene.SetActive(true);

            randomEventObject.SetActive(false);

            theCanvas.SetActive(true);


            /* Loop through each enemy and disable it
            foreach (GameObject enemy in enemies)
            {
                enemy.SetActive(true);
            }


            enemies = new GameObject[0];

            */

        }
    }
}
