using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class disableHealthBar : MonoBehaviour
{
    public GameObject theText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (nextRoomChecker.S.roomNumber % 10 == 0 && !nextRoomChecker.S.rollDone)
        {
            GetComponent<Image>().enabled = false;

            theText.SetActive(false);
        }
        else
        {
            GetComponent<Image>().enabled = true;
            theText.SetActive(true);
        }
    }
    
}
