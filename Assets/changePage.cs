using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class changePage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    IEnumerator changeScreen()
    {
        yield return new WaitForSeconds(0.5f);

        if (gameObject.name == "RightArrow")
        {
            pageStore.S.pageNumber++;
        }
        else if (gameObject.name.Contains("Left"))
        {
            pageStore.S.pageNumber--;
        }
    }

    public void change()
    {
        StartCoroutine(changeScreen());
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
