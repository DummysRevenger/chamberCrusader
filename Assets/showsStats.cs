using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showsStats : MonoBehaviour
{

    private string objectName;


    // Start is called before the first frame update
    void Start()
    {
        objectName = gameObject.name;

        Debug.Log(objectName);
    }

    // Update is called once per frame
    void Update()
    {
        switch(objectName)
        {
            case "totalScore":
                GetComponent<Text>().text = "Total Score = " + playerPrefsTest.pointsValue;
                break;

            case "highScore":
                GetComponent<Text>().text = "High Score = " + playerPrefsTest.highScoreValue;
                break;

            case "totalDeaths":
                GetComponent<Text>().text = "Deaths = " + playerPrefsTest.deathValue;
                break;

            case "totalKills":
                GetComponent<Text>().text = "Kills = " + playerPrefsTest.killsValue;
                break;

            case "totalAmmoPickups":
                GetComponent<Text>().text = "Ammo Pickups = " + playerPrefsTest.ammoValue;
                break;

            case "totalMeleeSwings":
                GetComponent<Text>().text = "Melee Swings = " + playerPrefsTest.swingsValue;
                break;

            case "totalShotsFired":
                GetComponent<Text>().text = "Shots Fired = " + playerPrefsTest.shotsValue;
                break;

            case "totalEnemiesEncountered":
                GetComponent<Text>().text = "Enemies Encountered = " + playerPrefsTest.enemiesEncounteredValue;
                break;

            case "totalRoomsCompleted":
                GetComponent<Text>().text = "Rooms Completed = " + playerPrefsTest.roomsCompleteValue;
                break;

            case "totalRoomsSeen":
                GetComponent<Text>().text = "Rooms Seen = " + playerPrefsTest.roomsSeenValue;
                break;

            case "totalRoomsSkipped":
                GetComponent<Text>().text = "Rooms Skipped = " + playerPrefsTest.roomsSkippedValue;
                break;

            case "totalCharactersUnlocked":
                GetComponent<Text>().text = "Characters Unlocked = " + playerPrefsTest.charactersUnlockedValue + "/3";
                break;
        }

    }
}
