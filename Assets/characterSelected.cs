using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterSelected : MonoBehaviour
{
    public GameObject playerSprite;
    public GameObject leftArrow;
    public GameObject rightArrow;
    public GameObject selectButton;
    public GameObject pageStore;

    public GameObject chamberText;






    // Update is called once per frame
    void Update()
    {

        


        if (selectCharacter.characterSelected != null)
        {
            playerSprite.SetActive(false);

            chamberText.SetActive(true);
            

        }
        else
        {
            playerSprite.SetActive(true);
            chamberText.SetActive(false);

        }
    }
}
