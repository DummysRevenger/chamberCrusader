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

    private static int tutorialValue;


    public static int deathValue;
    public static int pointsValue;
    public static int highScoreValue;
    public static int killsValue;
    public static int ammoValue;
    public static int swingsValue;
    public static int shotsValue;
    public static int enemiesEncounteredValue;
    public static int roomsCompleteValue;
    public static int roomsSeenValue;
    public static int roomsSkippedValue;
    public static int charactersUnlockedValue;

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

        tutorialValue = tutorialDoneChecker.tutorialDone ? 1 : 0;
            
            room10Value = room10Skipper.room10reached ? 1 : 0;

            room20Value = room20checker.room20Reached ? 1 : 0;

            room20BloodValue = room20checker.bloodRoom20Reached ? 1 : 0;

            room30BloodValue = room30checker.bloodRoom30Reached ? 1 : 0;

            room30Value = room30checker.room30Reached ? 1 : 0;

            blueBunnyValue = blueBunnyUnlockStore.bunnyUnlocked ? 1 : 0;

        // stats for stats screen

        

        deathValue = statsStore.deaths;
        pointsValue = statsStore.points;
        highScoreValue = statsStore.highScore;
        killsValue = statsStore.kills;
        ammoValue = statsStore.ammo;
        swingsValue = statsStore.swings;
        shotsValue = statsStore.shotsFired;
        enemiesEncounteredValue = statsStore.enemies;
        roomsCompleteValue = statsStore.roomsComplete;
        roomsSeenValue = statsStore.roomsSeen;
        roomsSkippedValue = statsStore.roomsSkipped;

        charactersUnlockedValue = statsStore.charactersUnlocked;

        


        PlayerPrefs.SetInt("deaths", deathValue);
        PlayerPrefs.SetInt("points", pointsValue);
        PlayerPrefs.SetInt("highscore", highScoreValue);
        PlayerPrefs.SetInt("kills", killsValue);
        PlayerPrefs.SetInt("ammo", ammoValue);
        PlayerPrefs.SetInt("swings", swingsValue);
        PlayerPrefs.SetInt("shots", shotsValue);
        PlayerPrefs.SetInt("enemies", enemiesEncounteredValue);
        PlayerPrefs.SetInt("roomsCompleted", roomsCompleteValue);
        PlayerPrefs.SetInt("roomsSeen", roomsSeenValue);
        PlayerPrefs.SetInt("roomsSkipped", roomsSkippedValue);
        PlayerPrefs.SetInt("charsUnlocked", charactersUnlockedValue);




        PlayerPrefs.SetInt("tutorialDone", tutorialValue);

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

        

        //load stats
        if (PlayerPrefs.HasKey("deaths"))
        {
            deathValue = PlayerPrefs.GetInt("deaths");

            statsStore.deaths = deathValue;

        }
        if (PlayerPrefs.HasKey("points"))
        {
            pointsValue = PlayerPrefs.GetInt("points");
            statsStore.points = pointsValue;
        }
        if (PlayerPrefs.HasKey("highscore"))
        {
            highScoreValue = PlayerPrefs.GetInt("highscore");
            statsStore.highScore = highScoreValue;
        }
        if (PlayerPrefs.HasKey("kills"))
        {
            
            killsValue = PlayerPrefs.GetInt("kills");

            
            

            statsStore.kills = killsValue;

        }
        if (PlayerPrefs.HasKey("ammo"))
        {
            ammoValue = PlayerPrefs.GetInt("ammo");

            statsStore.ammo = ammoValue;
        }
        if (PlayerPrefs.HasKey("swings"))
        {
            swingsValue = PlayerPrefs.GetInt("swings");

            statsStore.swings = swingsValue;
        }
        if (PlayerPrefs.HasKey("shots"))
        {
            shotsValue = PlayerPrefs.GetInt("shots");

            statsStore.shotsFired = shotsValue;

            
            
            

        }
        if (PlayerPrefs.HasKey("enemies"))
        {
            enemiesEncounteredValue = PlayerPrefs.GetInt("enemies");

            statsStore.enemies = enemiesEncounteredValue;

            
            

        }
        if (PlayerPrefs.HasKey("roomsCompleted"))
        {
            roomsCompleteValue = PlayerPrefs.GetInt("roomsCompleted");

            statsStore.roomsComplete = roomsCompleteValue;

            
            
            
        }
        if (PlayerPrefs.HasKey("roomsSeen"))
        {
            roomsSeenValue = PlayerPrefs.GetInt("roomsSeen");

            statsStore.roomsSeen = roomsSeenValue;
        }
        if (PlayerPrefs.HasKey("roomsSkipped"))
        {
            roomsSkippedValue = PlayerPrefs.GetInt("roomsSkipped");
            statsStore.roomsSkipped = roomsSkippedValue;
        }
        if (PlayerPrefs.HasKey("charsUnlocked"))
        {
            charactersUnlockedValue = PlayerPrefs.GetInt("charsUnlocked");

            statsStore.charactersUnlocked = charactersUnlockedValue;

            
            

            
        }


        // Load game data from PlayerPrefs

        if (PlayerPrefs.HasKey("tutorialDone"))
        {
            tutorialValue = PlayerPrefs.GetInt("tutorialDone");

            tutorialDoneChecker.tutorialDone = true;
        }


        if (PlayerPrefs.HasKey("room10"))
        {
            room10Value = PlayerPrefs.GetInt("room10");

            room10Skipper.room10reached = true;
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
