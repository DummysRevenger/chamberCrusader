using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backButtonTipBook : MonoBehaviour
{

    private GameObject theTipBook;

    // Start is called before the first frame update
    void Start()
    {
        theTipBook = GameObject.Find("tipBookCanvas");
    }

    public void onSelect()
    {
        theTipBook.SetActive(false);

        openTipBook.tipBookOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
