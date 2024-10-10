using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tipBookPageChange : MonoBehaviour
{

    private GameObject theTipBook;

    // Start is called before the first frame update
    void Start()
    {
        theTipBook = GameObject.Find("tipBookCanvas");
    }


    public void goBack()
    {
        if (gameObject.name != "LASTPAGE")
        {
            Invoke("delayGoingBack", 0.5f);
        }
        else
        {
            delayGoingBack();
        }
        
    }

    private void delayGoingBack()
    {
        if (tipBookPageStore.pageNumber > 1)
        {
            tipBookPageStore.pageNumber--;
        }
        else
        {
            theTipBook.SetActive(false);

            openTipBook.tipBookOpen = false;
        }
    }

    public void goNext()
    {
        if (tipBookPageStore.pageNumber < 2)
        {
            tipBookPageStore.pageNumber++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
