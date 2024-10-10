using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class abilityKeyColorChanger : MonoBehaviour
{

    public GameObject EY;

    public GameObject FG;

    private float alpha = 0.5f;

    private GameObject Ebox;
    private GameObject Fbox;
    private GameObject Gbox;
    private GameObject Ybox;

    public GameObject consumableTutorial;

    private int correctInputs;

    public GameObject ABILITIES;

    // Start is called before the first frame update
    void Start()
    {
        Ebox = EY.transform.GetChild(0).gameObject;
        Ybox = EY.transform.GetChild(1).gameObject;
        Fbox = FG.transform.GetChild(0).gameObject;
        Gbox = FG.transform.GetChild(1).gameObject;
    }

    void Update()
    {



        if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Y))
        {
            EY.GetComponent<Text>().color = new Color(0f, 1f, 0f);
            Ebox.GetComponent<Image>().color = new Color(0f, 1f, 0f, alpha);
            Ybox.GetComponent<Image>().color = new Color(0f, 1f, 0f, alpha);

            correctInputs++;
        }
        if (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.G))
        {
            FG.GetComponent<Text>().color = new Color(0f, 1f, 0f);
            Gbox.GetComponent<Image>().color = new Color(0f, 1f, 0f, alpha);
            Fbox.GetComponent<Image>().color = new Color(0f, 1f, 0f, alpha);

            correctInputs++;
        }

        if (correctInputs >= 2)
        {
            // decrease opacity
            alpha -= 0.02f;



            FG.GetComponent<Text>().color = new Color(0f, 1f, 0f, alpha);
            EY.GetComponent<Text>().color = new Color(0f, 1f, 0f, alpha);

            Gbox.GetComponent<Image>().color = new Color(0f, 1f, 0f, alpha);
            Fbox.GetComponent<Image>().color = new Color(0f, 1f, 0f, alpha);

            Ebox.GetComponent<Image>().color = new Color(0f, 1f, 0f, alpha);
            Ybox.GetComponent<Image>().color = new Color(0f, 1f, 0f, alpha);



            ABILITIES.SetActive(false);


            consumableTutorial.SetActive(true);


        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {








    }
}