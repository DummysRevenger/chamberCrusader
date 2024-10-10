using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playBossMusic : MonoBehaviour
{

    public GameObject bossMusicPlayer; // snake and necromancer boss music
    public GameObject thrombusMusicPlayer; // thrombus boss music
    public GameObject pyramidMusicPlayer; // pyramid boss music
    public GameObject abyssalHorrorMusicPlayer; //  abyssal Horror music



    public GameObject baseMusicPlayer;
    public GameObject secondMusicPlayer;
    public GameObject thirdMusicPlayer;
    public GameObject onionMusicPlayer;


    public GameObject thirdSong; // desert
    public GameObject secondSong; // blood 
    public GameObject song; // dungeon
    public GameObject onionSong; //onion
    public GameObject caveSong; // limbo 
    public GameObject mudSong; // mud
    public GameObject goldSong; // gold
    public GameObject darkSong; // dark
    public GameObject stormSong; // lust storm
    public GameObject b4StormSong; // before the storm (plays in vestibule and swamp for now and first 3 levels of storm)
    public GameObject gottaGetOutSong; // plays in the fire zone for now




    // Start is called before the first frame update
    void Start()
    {
        

        
       


    }

    // Update is called once per frame
    void Update()
    {




        if (selectCharacter.mapSelected == "retribution")
        {
            if (enemiesInRoomChecker.S.enemiesInRoomNumber == 0)
            {
                if (nextRoomChecker.S.roomNumber == 60) // necromancer
                {
                    bossMusicPlayer.SetActive(false);
                    b4StormSong.SetActive(true);
                }

                if (nextRoomChecker.S.roomNumber == 80) // thrombus
                {
                    thrombusMusicPlayer.SetActive(false);
                    secondMusicPlayer.SetActive(true);
                }

                if (nextRoomChecker.S.roomNumber == 90) // abyssal horror
                {
                    
                    abyssalHorrorMusicPlayer.SetActive(false);
                    darkSong.SetActive(true);
                }
            }
            else
            {

                    if (nextRoomChecker.S.roomNumber == 60) // necromancer
                    {
                        bossMusicPlayer.SetActive(true);
                        b4StormSong.SetActive(false);

                    Debug.Log("play necromancer music");
                }

                    if (nextRoomChecker.S.roomNumber == 80) // thrombus
                    {
                        thrombusMusicPlayer.SetActive(true);
                        secondMusicPlayer.SetActive(false);

                    Debug.Log("play thrombus music");
                    }

                if (nextRoomChecker.S.roomNumber == 90) // abyssal horror
                {
                    abyssalHorrorMusicPlayer.SetActive(true);
                    darkSong.SetActive(false);

                    Debug.Log("play octopus music");
                }
            }


            

            


        }
        else
        {

            if (nextRoomChecker.S.roomNumber == 20)
            {
                if (enemiesInRoomChecker.S.enemiesInRoomNumber >= 1)
                { 
                    

                    switch (selectCharacter.mapSelected)
                    {
                        case "dungeon":
                            bossMusicPlayer.SetActive(true);
                            break;

                        case "blood":
                            thrombusMusicPlayer.SetActive(true);
                            break;

                        case "desert":
                            pyramidMusicPlayer.SetActive(true);
                            break;
                    }

                    baseMusicPlayer.SetActive(false);
                    secondMusicPlayer.SetActive(false);
                    thirdMusicPlayer.SetActive(false);
                }
                else
                {
                    bossMusicPlayer.SetActive(false);

                    switch (selectCharacter.mapSelected)
                    {
                        case "dungeon":
                            baseMusicPlayer.SetActive(true);
                            break;

                        case "blood":
                            secondMusicPlayer.SetActive(true);
                            break;

                        case "desert":
                            thirdMusicPlayer.SetActive(true);
                            break;

                        case "onion":
                            onionMusicPlayer.SetActive(true);
                            break;
                        
                    }



                }
            }

        }
    }
}
