using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pageStore : MonoBehaviour
{
    public static pageStore S;

    public int pageNumber = 1;
    public GameObject right;
    public GameObject leftChar;

    public GameObject leftMap;

    public GameObject backButton;

    private bool pagesReset = false;

    // player character 

    public GameObject knightStats;

    public GameObject ninjaStats;

    public GameObject soldierStats;

    public GameObject bunnyStats;



    public GameObject zoneDescriptionBackground;

    public GameObject bloodDescriptionBackground;

    public GameObject desertDescriptionBackground;

    public GameObject theOnionDescriptionBackground;

    public GameObject retributionDescriptionBackground;


    // Start is called before the first frame update
    void Start()
    {
        S = this;
    }

    // Update is called once per frame
    void Update()
    {




        if (screenStore.S.currentScreen == "char")
        {


            switch(pageNumber)
            {
                case 1:
                    leftChar.SetActive(false);
                    right.SetActive(true);
                    knightStats.SetActive(true);
                    ninjaStats.SetActive(false);
                    break;
                case 2:
                    leftChar.SetActive(true);
                    right.SetActive(true);
                    ninjaStats.SetActive(true);
                    soldierStats.SetActive(false);
                    knightStats.SetActive(false);
                    break;
                case 3:
                    ninjaStats.SetActive(false);
                    soldierStats.SetActive(true);
                    bunnyStats.SetActive(false);
                    break;
                case 4:
                    
                    leftChar.SetActive(true);
                    bunnyStats.SetActive(true);
                    soldierStats.SetActive(false);
                    break;
                case 5:
                    
                    leftChar.SetActive(true);
                    bunnyStats.SetActive(false);
                    break;
                case 6:
                    
                    leftChar.SetActive(true);
                    
                    break;
                case 7:
                    
                    leftChar.SetActive(true);
                    
                    break;
                case 8:
                    
                    leftChar.SetActive(true);
                    
                    break;
                case 9:
                    
                    leftChar.SetActive(true);
                    
                    break;
                case 10:
                    
                    leftChar.SetActive(true);
                    
                    break;
                case 11:
                    
                    leftChar.SetActive(true);
                    
                    break;
                case 12:
                    right.SetActive(false);
                    leftChar.SetActive(true);
                    
                    break;

            }

            

        }
        else if (screenStore.S.currentScreen == "map")
        {

            

            if (pageNumber == 1)
            {
                leftMap.SetActive(false);
                right.SetActive(true);
                zoneDescriptionBackground.SetActive(true);
            }
            else if (pageNumber == 2)
            {
                leftMap.SetActive(true);
                right.SetActive(true);
                bloodDescriptionBackground.SetActive(true);
            }
            else if (pageNumber == 3)
            {
                right.SetActive(true);
                leftMap.SetActive(true);
                desertDescriptionBackground.SetActive(true);
            }
            else if(pageNumber == 4)
            {
                right.SetActive(true);
                leftMap.SetActive(true);
                theOnionDescriptionBackground.SetActive(true);
            }
            else if(pageNumber == 5)
            {
                leftMap.SetActive(true);
                right.SetActive(false);
                retributionDescriptionBackground.SetActive(true);
            }
        }
        

        if (selectCharacter.characterSelected != null && !pagesReset)
        {
            pageNumber = 1;
            pagesReset = true;
            backButton.SetActive(true);
            
        }
       
    }
}
