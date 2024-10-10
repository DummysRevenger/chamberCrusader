using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openTipBook : MonoBehaviour
{
    


    public GameObject tipBook;

    public static bool tipBookOpen = false;
    

    // Start is called before the first frame update
    void Start()
    {
        

        tipBook.SetActive(false);
    }

    public void openIt()
    {
        if (gameObject.name != "tipBook")
        {
            Invoke("delayOpen", 0.5f);
        }
        else
        {
            delayOpen();
        }
        
        
    }

    void delayOpen()
    {
        tipBook.SetActive(true);


        tipBookOpen = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
