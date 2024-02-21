using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class statsButton : MonoBehaviour
{
    public Text theText;


    IEnumerator changeScreen()
    {
        yield return new WaitForSeconds(0.5f);

        screenStore.S.currentScreen = "stats";
    }


    public void OnClick()
    {



        theText.enabled = false;
        StartCoroutine(changeScreen());
    }




}
