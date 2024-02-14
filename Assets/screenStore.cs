using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            case "title":
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

                break;

            case "char":
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
