using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class consumableTutorialKeyChanger : MonoBehaviour
{
    public GameObject CN;

    private int correctInputs;

    

    public GameObject theTutorial;

    private float alpha = 0.5f;

    private GameObject Cbox;
    private GameObject Nbox;

    // Start is called before the first frame update
    void Start()
    {
        Cbox = CN.transform.GetChild(0).gameObject;
        Nbox = CN.transform.GetChild(1).gameObject;
        
    }

    void Update()
    {


        if (Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.N))
        {
            CN.GetComponent<Text>().color = new Color(0f, 1f, 0f);
            Nbox.GetComponent<Image>().color = new Color(0f, 1f, 0f, alpha);
            Cbox.GetComponent<Image>().color = new Color(0f, 1f, 0f, alpha);

            correctInputs++;
        }


        if (correctInputs >= 1)
        {
            // decrease opacity
            alpha -= 0.02f;



            CN.GetComponent<Text>().color = new Color(0f, 1f, 0f, alpha);
            

            Cbox.GetComponent<Image>().color = new Color(0f, 1f, 0f, alpha);
            Nbox.GetComponent<Image>().color = new Color(0f, 1f, 0f, alpha);



            theTutorial.SetActive(false);


            tutorialDoneChecker.tutorialDone = true;

        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {








    }
}
