using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class obscureTip : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        char penString = gameObject.name[gameObject.name.Length - 2];

        char lastString = gameObject.name[gameObject.name.Length - 1];


        string last2Chars = penString.ToString() + lastString.ToString();




        int lastCharsInt = int.Parse(last2Chars);




        if (tipUnlockStore.unlockedTips.Contains(lastCharsInt))
        {
            GetComponent<Text>().text = tipUnlockStore.tipList[lastCharsInt - 1];
        }
        else
        {
            GetComponent<Text>().text = "???????????????????????";
        }
    }
}
