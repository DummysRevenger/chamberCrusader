using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controlsButton : MonoBehaviour
{
    public Text theText;


   
    IEnumerator changeScreen()
    {
        yield return new WaitForSeconds(0.5f);

        screenStore.S.currentScreen = "controls";
    }


    public void OnClick()
    {
        theText.enabled = false;
        StartCoroutine(changeScreen());
    }


    
}
