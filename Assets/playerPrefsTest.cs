using UnityEngine;

public class playerPrefsTest : MonoBehaviour
{
    // Example variables to be saved
    
    
    private static int room20Value;
    private static int room30Value;

    private static int room10Value;

    private static int room20BloodValue;
    private static int room30BloodValue;

    private static int blueBunnyValue;

    private void Start()
    {

        



    // Load saved data when the game starts
    LoadGameData();
    }

    private void Update()
    {



        // Example code to update game data


        



        SaveGameData();



        }



        private void SaveGameData()
        {
        // Save game data using PlayerPrefs


            room10Value = room10Skipper.room10reached ? 1 : 0;

            room20Value = room20checker.room20Reached ? 1 : 0;

            room20BloodValue = room20checker.bloodRoom20Reached ? 1 : 0;

            room30BloodValue = room30checker.bloodRoom30Reached ? 1 : 0;

            room30Value = room30checker.room30Reached ? 1 : 0;

            blueBunnyValue = blueBunnyUnlockStore.bunnyUnlocked ? 1 : 0;

            PlayerPrefs.SetInt("room10", room10Value);
            PlayerPrefs.SetInt("room20", room20Value);
            PlayerPrefs.SetInt("room30", room30Value);

            PlayerPrefs.SetInt("roomBlood20", room20BloodValue);
            PlayerPrefs.SetInt("roomBlood30", room30BloodValue);

            PlayerPrefs.SetInt("bunny", blueBunnyValue);

        // Call PlayerPrefs.Save() to write the data to disk immediately (optional)
        PlayerPrefs.Save();
        }

        private void LoadGameData()
        {
        // Load game data from PlayerPrefs

        if (PlayerPrefs.HasKey("room10"))
        {
            room10Value = PlayerPrefs.GetInt("room10");
        }

        if (PlayerPrefs.HasKey("bunny"))
        {
            blueBunnyValue = PlayerPrefs.GetInt("bunny");

            blueBunnyUnlockStore.bunnyUnlocked = true;
        }


        if (PlayerPrefs.HasKey("roomBlood20"))
        {
            room20BloodValue = PlayerPrefs.GetInt("roomBlood20");

            if (room20BloodValue == 1)
            {
                room20checker.bloodRoom20Reached = true;

                
            }
            else
            {
                room20checker.bloodRoom20Reached = false;
            }
            
        }

        if (PlayerPrefs.HasKey("roomBlood30"))
        {
            room30BloodValue = PlayerPrefs.GetInt("roomBlood30");

            if (room30BloodValue == 1)
            {
                room30checker.bloodRoom30Reached = true;
                
            }
            else
            {
                room30checker.bloodRoom30Reached = false;
            }
            
        }

        if (PlayerPrefs.HasKey("room20"))
            {
                room20Value = PlayerPrefs.GetInt("room20");

                if (room20Value == 1)
                {
                    room20checker.room20Reached = true;
                
            }
            else
            {
                room20checker.room20Reached = false;
            }

            }

            if (PlayerPrefs.HasKey("room30"))
            {
                room30Value = PlayerPrefs.GetInt("room30");

                if (room30Value == 1)
                {
                    room30checker.room30Reached = true;
                
            }
                else
                {
                room30checker.room30Reached = false;
                }
                
            }

        }
    }
