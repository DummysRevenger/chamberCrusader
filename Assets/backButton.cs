using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class backButton : MonoBehaviour
{

    public Text startButtonText;

    

    IEnumerator changeScreen()
    {
        yield return new WaitForSeconds(0.5f);

        if (screenStore.S.currentScreen == "char")
        {
            gameObject.SetActive(false);
            screenStore.S.currentScreen = "title";
            startButtonText.enabled = true;

        }
        else if (screenStore.S.currentScreen == "map")
        {
            selectCharacter.characterSelected = null;
            screenStore.S.currentScreen = "char";
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
