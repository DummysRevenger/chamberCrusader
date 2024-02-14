using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class chamberTextChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(pageStore.S.pageNumber)
        {
            case 1:
                gameObject.GetComponent<Text>().text = "The Dungeon";
                break;
            case 2:
                gameObject.GetComponent<Text>().text = "The Blood Zone";
                break;
            case 3:
                gameObject.GetComponent<Text>().text = "The Desert";
                break;
        }

    }
}
