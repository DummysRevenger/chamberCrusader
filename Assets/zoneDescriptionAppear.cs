using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zoneDescriptionAppear : MonoBehaviour
{
    private GameObject descriptionText;
    private Image descriptionBackground;
    private GameObject difficultyText;

    // Start is called before the first frame update
    void Start()
    {


        switch(gameObject.name)
        {
            case "dungeonDescriptionBackground":
                descriptionText = GameObject.Find("dungeonDescription");
                difficultyText = GameObject.Find("dungeonDifficultyText");
                break;
            case "bloodDescriptionBackground":
                descriptionText = GameObject.Find("bloodDescription");
                difficultyText = GameObject.Find("bloodDifficultyText");
                break;
            case "desertDescriptionBackground":
                descriptionText = GameObject.Find("desertDescription");
                difficultyText = GameObject.Find("desertDifficultyText");
                break;
            case "onionDescriptionBackground":
                descriptionText = GameObject.Find("onionDescription");
                difficultyText = GameObject.Find("onionDifficultyText");
                break;
            case "retributionDescriptionBackground":
                descriptionText = GameObject.Find("retributionDescription");
                difficultyText = GameObject.Find("retributionDifficultyText");
                break;

        }
        
        descriptionBackground = GetComponent<Image>();

        descriptionBackground.enabled = false;

        descriptionText.GetComponent<Text>().enabled = false;

        difficultyText.GetComponent<Text>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (screenStore.S.currentScreen == "map")
        {
            if (pageStore.S.pageNumber == 1)
            {
                
                if (gameObject.name.Contains("dungeon"))
                {
                    descriptionText.GetComponent<Text>().enabled = true;
                    difficultyText.GetComponent<Text>().enabled = true;
                }
                else
                {
                    descriptionText.GetComponent<Text>().enabled = false;
                    difficultyText.GetComponent<Text>().enabled = false;
                }

                
                    
                
            }
            else if (pageStore.S.pageNumber == 2)
            {


                if (gameObject.name.Contains("blood"))
                {
                    descriptionText.GetComponent<Text>().enabled = true;
                    difficultyText.GetComponent<Text>().enabled = true;
                }
                else
                {
                    descriptionText.GetComponent<Text>().enabled = false;
                    difficultyText.GetComponent<Text>().enabled = false;
                }

            }
            else if (pageStore.S.pageNumber == 3)
            {



                if (gameObject.name.Contains("desert"))
                {
                    descriptionText.GetComponent<Text>().enabled = true;
                    difficultyText.GetComponent<Text>().enabled = true;
                }
                else
                {
                    descriptionText.GetComponent<Text>().enabled = false;
                    difficultyText.GetComponent<Text>().enabled = false;
                }

            }
            else if (pageStore.S.pageNumber == 4)
            {



                if (gameObject.name.Contains("onion"))
                {
                    descriptionText.GetComponent<Text>().enabled = true;
                    difficultyText.GetComponent<Text>().enabled = true;
                }
                else
                {
                    descriptionText.GetComponent<Text>().enabled = false;
                    difficultyText.GetComponent<Text>().enabled = false;
                }

            }
            else if (pageStore.S.pageNumber == 5)
            {



                if (gameObject.name.Contains("retribution"))
                {
                    descriptionText.GetComponent<Text>().enabled = true;
                    difficultyText.GetComponent<Text>().enabled = true;
                }
                else
                {
                    descriptionText.GetComponent<Text>().enabled = false;
                    difficultyText.GetComponent<Text>().enabled = false;
                }
            }
        }
    }
}
