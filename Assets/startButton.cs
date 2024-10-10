using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startButton : MonoBehaviour
{
    public Text theText;
    

    void changeScreen()
    {

        
        
        screenStore.S.currentScreen = "char";

        


    }



    public void Select()
    {

        

        theText.enabled = false;
        Invoke("changeScreen", 0.5f);
    }

    


}
