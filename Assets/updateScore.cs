using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateScore : MonoBehaviour
{
    public Text text;
    

    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        string formattedNumber = pointsStore.S.points.ToString("D5");

        if (gameObject.name == "score")
        {
            

            text.text = "Score:" + formattedNumber;
        }
        else
        {
            text.text = "Final Score:" + formattedNumber;
        }


    }
}
