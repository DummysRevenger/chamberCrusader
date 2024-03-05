using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class screenStore : MonoBehaviour
{
    public static screenStore S;
    public string currentScreen = "title";

    public GameObject settingsButton;
    public GameObject title;
    public GameObject playerSprite;
    public GameObject selectButton;
    public GameObject backButton;
    public GameObject rightArrow;

    public GameObject leftArrow;

    public GameObject startButton;

    public GameObject selectChar;

    public GameObject selectCham;


    public GameObject pageStore;

    public GameObject characterSelected;

    public GameObject desertCondition;

    public GameObject bloodCondition;

    public GameObject SUnlock;

    public GameObject NUnlock;

    public GameObject BUnlock;

    public GameObject statsButton;

    //stats screen
    public GameObject theStatsTitleText;

    public GameObject totalScoreText;

    public GameObject totalDeathsText;

    public GameObject totalKillsText;

    public GameObject totalAmmoPickupsText;

    public GameObject totalMeleeSwingsText;

    public GameObject shotsFiredText;

    public GameObject enemiesEncounteredText;

    public GameObject roomsCompletedText;

    public GameObject roomsSeenText;

    public GameObject roomsSkippedText;

    public GameObject charactersUnlockedText;

    public GameObject highScore;

    public GameObject statsBackground;

    public Text statsButtonText;

    // Start is called before the first frame update
    void Start()
    {
        S = this;
        //settingsButton.SetActive(true);
        title.SetActive(true);
        selectButton.SetActive(false);

        rightArrow.SetActive(false);
        backButton.SetActive(false);
        playerSprite.SetActive(false);
        pageStore.SetActive(false);
        characterSelected.SetActive(false);
    }

    

    // Update is called once per frame
    void Update()
    {

        switch(screenStore.S.currentScreen)
        {
            case "stats":
                title.SetActive(false);
                selectButton.SetActive(false);

                

                statsBackground.SetActive(true);

                highScore.SetActive(true);

                theStatsTitleText.SetActive(true);

                totalScoreText.SetActive(true);

                totalDeathsText.SetActive(true); 
                
                totalKillsText.SetActive(true); 

                totalAmmoPickupsText.SetActive(true); 

                totalMeleeSwingsText.SetActive(true); 

                shotsFiredText.SetActive(true);

                enemiesEncounteredText.SetActive(true); 

                roomsCompletedText.SetActive(true);

                roomsSeenText.SetActive(true); 

                roomsSkippedText.SetActive(true); 

                charactersUnlockedText.SetActive(true); 

    


                startButton.SetActive(false);

                statsButtonText.enabled = false;

                statsButton.SetActive(false);

                backButton.SetActive(true);


                break;



            case "title":
                highScore.SetActive(false);

                statsButton.SetActive(true);

                statsButtonText.enabled = true;



                statsBackground.SetActive(false);

                theStatsTitleText.SetActive(false);

                totalScoreText.SetActive(false);

                totalDeathsText.SetActive(false);

                totalKillsText.SetActive(false);

                totalAmmoPickupsText.SetActive(false);

                totalMeleeSwingsText.SetActive(false);

                shotsFiredText.SetActive(false);

                enemiesEncounteredText.SetActive(false);

                roomsCompletedText.SetActive(false);

                roomsSeenText.SetActive(false);

                roomsSkippedText.SetActive(false);

                charactersUnlockedText.SetActive(false); 


                //settingsButton.SetActive(true);
                title.SetActive(true);
                selectButton.SetActive(false);

                rightArrow.SetActive(false);
                leftArrow.SetActive(false);
                backButton.SetActive(false);
                playerSprite.SetActive(false);
                pageStore.SetActive(false);
                characterSelected.SetActive(false);

                startButton.SetActive(true);

                selectChar.SetActive(false);

                bloodCondition.SetActive(false);
                desertCondition.SetActive(false);

                NUnlock.SetActive(false);
                SUnlock.SetActive(false);
                BUnlock.SetActive(false);

                break;

            case "char":

                statsButton.SetActive(false);


                //settingsButton.SetActive(false);
                title.SetActive(false);
                selectButton.SetActive(true);

                rightArrow.SetActive(true);
                backButton.SetActive(true);
                playerSprite.SetActive(true);
                pageStore.SetActive(true);
                characterSelected.SetActive(true);
                startButton.SetActive(false);

                selectCham.SetActive(false);
                selectChar.SetActive(true);

                desertCondition.SetActive(false);
                bloodCondition.SetActive(false);


                break;

            case "map":
                selectCham.SetActive(true);
                selectChar.SetActive(false);

                NUnlock.SetActive(false);
                SUnlock.SetActive(false);

                break;

        }

        

    }
}
