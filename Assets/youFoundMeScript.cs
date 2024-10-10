using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class youFoundMeScript : MonoBehaviour
{
    private float seconds = 0f;

    private Text theText;

    // Start is called before the first frame update
    void Start()
    {
        theText = GetComponent<Text>();

        seconds = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime;


        if ((int)seconds == 2)
        {
            theText.text = "I didn't expect you to get this far...";
        }
        else if ((int)seconds == 6)
        {
            theText.text = "guess you exceed expectations at least in this game";
        }
        else if ((int)seconds == 12)
        {
            theText.text = "some patience would be welcome";
        }
        else if ((int)seconds == 13)
        {
            theText.text = ".";
        }
        else if ((int)seconds == 15)
        {
            theText.text = "..";
        }
        else if ((int)seconds == 17)
        {
            theText.text = "...";
        }
        else if ((int)seconds == 20)
        {
            theText.text = "damn it!";
        }
        else if ((int)seconds == 23)
        {
            theText.text = "I can't do anything on the spot!";
        }
        else if ((int)seconds == 27)
        {
            theText.text = "anyway";
        }
        else if ((int)seconds == 32)
        {
            theText.text = "I'm a bit bored with this game";
        }
        else if ((int)seconds == 37)
        {
            theText.text = "it took a long f***ing time " +
                "and lots of effort to get here";
        }
        else if ((int)seconds == 43)
        {
            theText.text = "I never wanted you here anyway";
        }
        else if ((int)seconds == 46)
        {
            theText.text = "so scram!";
        }
        else if ((int)seconds == 50)
        {
            hpStorePlayer.S.playerHealth = -999999999999;
        }
    }
}
