using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeMainMenuCanvas : MonoBehaviour
{
    private GameObject mainMenuCanvas;

    // Start is called before the first frame update
    void Start()
    {
        mainMenuCanvas = GameObject.Find("mainMenuCanvas");
    }


    public void closetheCanvas()
    {
        Invoke("delayClose", 0.5f);
    }

    void delayClose()
    {
        mainMenuCanvas.SetActive(false);
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
