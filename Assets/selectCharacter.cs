using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selectCharacter : MonoBehaviour
{
    public static string characterSelected;
    public static string mapSelected;



    // Start is called before the first frame update
    void Start()
    {
        characterSelected = null;

        
        
    }

    public void select()
    {

        if (characterSelected == null) //character selection screen
        {

            switch (pageStore.S.pageNumber)
            {
                case 1:
                    characterSelected = "knight";


                    break;
                case 2:
                    if ((room30checker.room30Reached))
                    {

                        characterSelected = "ninja";
                    }
                    break;
                case 3:
                    if ((room30checker.bloodRoom30Reached))
                    {
                        characterSelected = "soldier";

                    }
                    break;
                case 4:
                    if (blueBunnyUnlockStore.bunnyUnlocked)
                    {
                        characterSelected = "bunny";

                        pageStore.S.pageNumber = 1;
                    }
                    break;
            }
        }
        else // map selection screen
        {




            switch (pageStore.S.pageNumber)
            {
                case 1:
                    mapSelected = "dungeon";
                    SceneManager.LoadScene("fightingScene");
                    break;

                case 2:


                    if (room20checker.room20Reached)
                    {
                        mapSelected = "blood";
                        SceneManager.LoadScene("fightingScene");
                    }




                    break;
                case 3:

                    if (room20checker.bloodRoom20Reached)
                    {
                        mapSelected = "desert";
                        SceneManager.LoadScene("fightingScene");
                    }




                    break;
            }
        }

    }

    void Update()
    {
        if (characterSelected != null) //character selection screen
        {
            screenStore.S.currentScreen = "map";
        }
        
    }
}
