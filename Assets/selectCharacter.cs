using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selectCharacter : MonoBehaviour
{
    public static string characterSelected;
    public static string mapSelected;

    public GameObject LetsGoButton;

    private bool onCooldown = false;

    // Start is called before the first frame update
    void Start()
    {
        characterSelected = null;

        
        
    }

    public void goOffCooldown()
    {
        onCooldown = false;
    }


    public void loadItemSelect()
    {
        screenStore.S.currentScreen = "itemSelect";
    }

    public void select()
    {

        if (!onCooldown)
        {
            if (characterSelected == null) //character selection screen
            {
                screenStore.S.currentScreen = "map";
                switch (pageStore.S.pageNumber)
                {
                    case 1:
                        characterSelected = "knight";


                        break;
                    case 2:
                        /*if ((room30checker.room30Reached))
                        {
                            */
                        characterSelected = "ninja";
                        //}
                        break;
                    case 3:
                        /*if ((room30checker.bloodRoom30Reached))
                        {*/
                        characterSelected = "soldier";

                        //}
                        break;
                    case 4:
                        /*if (blueBunnyUnlockStore.bunnyUnlocked)
                        {*/
                        characterSelected = "bunny";

                        
                        //}
                        break;
                    case 5:
                        /*if (blueBunnyUnlockStore.bunnyUnlocked)
                        {*/
                        characterSelected = "shop";


                        //}
                        break;
                    case 6:
                        /*if (blueBunnyUnlockStore.bunnyUnlocked)
                        {*/
                        characterSelected = "pride";


                        //}
                        break;
                    case 7:
                        /*if (blueBunnyUnlockStore.bunnyUnlocked)
                        {*/
                        characterSelected = "envy";


                        //}
                        break;
                    case 8:
                        /*if (blueBunnyUnlockStore.bunnyUnlocked)
                        {*/
                        characterSelected = "wrath";


                        //}
                        break;
                    case 9:
                        /*if (blueBunnyUnlockStore.bunnyUnlocked)
                        {*/
                        characterSelected = "sloth";


                        //}
                        break;
                    case 10:
                        /*if (blueBunnyUnlockStore.bunnyUnlocked)
                        {*/
                        characterSelected = "greed";


                        //}
                        break;
                    case 11:
                        /*if (blueBunnyUnlockStore.bunnyUnlocked)
                        {*/
                        characterSelected = "gluttony";


                        //}
                        break;
                    case 12:
                        /*if (blueBunnyUnlockStore.bunnyUnlocked)
                        {*/
                        characterSelected = "lust";


                        //}
                        break;
                }

                pageStore.S.pageNumber = 1;
            }
            else // map selection screen
            {


                screenStore.S.currentScreen = "itemSelect";

                switch (pageStore.S.pageNumber)
                {
                    case 1:
                        mapSelected = "dungeon";

                        break;

                    case 2:


                        /*if (room20checker.room20Reached)
                        {*/
                        mapSelected = "blood";

                        //}




                        break;
                    case 3:

                        /*if (room20checker.bloodRoom20Reached)
                        {*/
                        mapSelected = "desert";

                        //}
                        break;

                    case 4:

                        mapSelected = "onion";

                        break;

                    case 5:
                        mapSelected = "retribution";

                        break;


                }



                
                
            }

            onCooldown = true;

            Invoke("goOffCooldown", 0.5f);
        }
    }

    void Update()
    { 
        
        

    }
}
