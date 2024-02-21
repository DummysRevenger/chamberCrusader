using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pageStore : MonoBehaviour
{
    public static pageStore S;

    public int pageNumber = 1;
    public GameObject right;
    public GameObject left;

    public GameObject backButton;

    private bool pagesReset = false;

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


            if (pageNumber == 1)
            {
                left.SetActive(false);
                right.SetActive(true);
            }
            else if (pageNumber == 2)
            {
                left.SetActive(true);
                right.SetActive(true);
            }


            else if (pageNumber == 4)
            {
                right.SetActive(false);
                left.SetActive(true);
            }

        }
        else if (screenStore.S.currentScreen == "map")
        { 

            

            if (pageNumber == 1)
            {
                left.SetActive(false);
                right.SetActive(true);
            }
            else if (pageNumber == 2)
            {
                left.SetActive(true);
                right.SetActive(true);
            }
            else if (pageNumber == 3)
            {
                right.SetActive(false);
                left.SetActive(true);
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
