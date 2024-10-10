using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tipBookPageStore : MonoBehaviour
{

    private GameObject lastPage;

    private GameObject nextPage;

    public static int pageNumber = 1;

    private GameObject page1;

    private GameObject page2;

    // Start is called before the first frame update
    void Start()
    {
        lastPage = GameObject.Find("LASTPAGE");

        nextPage = GameObject.Find("NEXTPAGE");

        page1 = GameObject.Find("PAGE 1");

        page2 = GameObject.Find("PAGE 2");

    }

    // Update is called once per frame
    void Update()
    {
        
        switch(pageNumber)
        {
            case 1:
                nextPage.SetActive(true);
                page1.SetActive(true);
                page2.SetActive(false);
                break;
            case 2:
                lastPage.SetActive(true);
                nextPage.SetActive(false);
                page2.SetActive(true);
                page1.SetActive(false);
                break;
        }
    }
}
