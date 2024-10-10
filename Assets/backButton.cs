using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class backButton : MonoBehaviour
{

    public Text startButtonText;

    private bool onCooldown = false;

    
    public void goOffCooldown()
    {
        onCooldown = false;
    }

    

    IEnumerator changeScreen()
    {
        yield return new WaitForSeconds(0.5f);


        if (!onCooldown)
        {
            if (screenStore.S.currentScreen == "char")
            {
                gameObject.SetActive(false);
                screenStore.S.currentScreen = "title";
                startButtonText.enabled = true;

                onCooldown = true;

                
            }
            else if (screenStore.S.currentScreen == "map")
            {
                selectCharacter.characterSelected = null;
                screenStore.S.currentScreen = "char";

                onCooldown = true;

                
            }
            else if (screenStore.S.currentScreen == "stats" || screenStore.S.currentScreen == "controls")
            {
                screenStore.S.currentScreen = "title";

                onCooldown = true;
            }
            else if (screenStore.S.currentScreen == "itemSelect")
            {
                screenStore.S.currentScreen = "map";
                selectCharacter.mapSelected = null;

                onCooldown = true;
            }

            Invoke("goOffCooldown", 0.5f);
        }
        


    }


    public void GoBack()
    {

        StartCoroutine(changeScreen());
        
        
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
