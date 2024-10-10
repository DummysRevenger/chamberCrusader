using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openMainMenuCanvas : MonoBehaviour
{


    public GameObject mainMenuCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void opennTheCanvas()
    {
        Invoke("openDelay", 0.49f);
    }

    void openDelay()
    {
        if (tipBookPageStore.pageNumber == 1)
        {
            mainMenuCanvas.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
