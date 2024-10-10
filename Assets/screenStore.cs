using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class screenStore : MonoBehaviour
{
    public static screenStore S;
    public string currentScreen = "title";

    private GameObject tipBookButton;

    private GameObject leftMoney;

    private GameObject rightMoney;

    public GameObject settingsButton;
    public GameObject title;
    public GameObject playerSprite;
    public GameObject selectButton;
    public GameObject backButton;
    public GameObject rightArrow;

    public GameObject leftArrowChar;

    public GameObject leftArrowMap;

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


    public GameObject controlsButton;


    // for controls screen
    public GameObject controlsScreenBackground;

    public GameObject controlsScreenBoard;

    public Text controlsButtonText;

    public GameObject knightStats;

    public GameObject ninjaStats;

    public GameObject soldierStats;

    public GameObject bunnyStats;

    public GameObject itemSelectBackground;

    public GameObject LetsGoButton;

    public GameObject chamberText;

    public GameObject zoneDescriptionBackground;

    public GameObject bloodDescriptionBackground;

    public GameObject desertDescriptionBackground;

    public GameObject theOnionDescriptionBackground;

    public GameObject retributionDescriptionBackground;

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

        tipBookButton = GameObject.Find("tipBookButton");

        rightMoney = GameObject.Find("rightMoneyText");

        leftMoney = GameObject.Find("leftMoneyText");
    }

    

    // Update is called once per frame
    void Update()
    {

        
        

        switch(screenStore.S.currentScreen)
        {
            case "controls":

                // code for the controls screen
                

                statsButton.SetActive(false);

                tipBookButton.SetActive(false);


                startButton.SetActive(false);


                controlsScreenBackground.SetActive(true);

                controlsScreenBoard.SetActive(true);

                controlsButton.SetActive(false);

                
                //settingsButton.SetActive(true);
                title.SetActive(false);
                selectButton.SetActive(false);


                backButton.SetActive(true);

                pageStore.SetActive(false);

                characterSelected.SetActive(false);
                break;


            case "stats":

                controlsButton.SetActive(false);


                title.SetActive(false);
                selectButton.SetActive(false);

                tipBookButton.SetActive(false);

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

                controlsButton.SetActive(true);

                rightMoney.SetActive(true);

                leftMoney.SetActive(false);

                tipBookButton.SetActive(true);

                controlsButtonText.enabled = true;

                controlsScreenBackground.SetActive(false);

                controlsScreenBoard.SetActive(false);

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
                leftArrowChar.SetActive(false);


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

                knightStats.SetActive(false);
                bunnyStats.SetActive(false);
                ninjaStats.SetActive(false);
                soldierStats.SetActive(false);

                break;

            case "char":

                leftMoney.SetActive(true);

                rightMoney.SetActive(false);

                tipBookButton.SetActive(false);

                

                leftArrowMap.SetActive(false);

                

                controlsButton.SetActive(false);


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

                zoneDescriptionBackground.SetActive(false);

                zoneDescriptionBackground.GetComponent<Image>().enabled = false;


                break;

            case "map":

                leftArrowChar.SetActive(false);

                knightStats.SetActive(false);
                bunnyStats.SetActive(false);
                ninjaStats.SetActive(false);
                soldierStats.SetActive(false);


                selectCham.SetActive(true);
                selectChar.SetActive(false);

                NUnlock.SetActive(false);
                SUnlock.SetActive(false);

                itemSelectBackground.SetActive(false);

                chamberText.GetComponent<Text>().enabled = true;

                zoneDescriptionBackground.SetActive(true);

                zoneDescriptionBackground.GetComponent<Image>().enabled = true;



                selectButton.SetActive(true);

                chamberText.SetActive(true);

                chamberText.GetComponent<Text>().enabled = true;

                selectCham.SetActive(true);

                break;


            case "itemSelect":

                zoneDescriptionBackground.SetActive(false);

                zoneDescriptionBackground.GetComponent<Image>().enabled = false;

                bloodDescriptionBackground.SetActive(false);

                bloodDescriptionBackground.GetComponent<Image>().enabled = false;

                desertDescriptionBackground.SetActive(false);

                desertDescriptionBackground.GetComponent<Image>().enabled = false;

                retributionDescriptionBackground.SetActive(false);

                retributionDescriptionBackground.GetComponent<Image>().enabled = false;

                theOnionDescriptionBackground.SetActive(false);

                theOnionDescriptionBackground.GetComponent<Image>().enabled = false;

                selectCham.SetActive(false);

                chamberText.SetActive(false);

                chamberText.GetComponent<Text>().enabled = false;

                itemSelectBackground.SetActive(true);

                LetsGoButton.SetActive(true);

                selectButton.SetActive(false);

                leftArrowMap.SetActive(false);

                rightArrow.SetActive(false);

                break;
        }

        

    }

    
}
