using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setChartToPride : MonoBehaviour
{
    

    public GameObject greed;
    public GameObject gluttony;
    public GameObject envy;
    public GameObject wrath;
    public GameObject lust;
    public GameObject sloth;
    public GameObject pride;



    void Awake()
    {
        

        if (gameObject.name.Contains("Greed"))
        {
            greed.SetActive(true);
            selectCharacter.characterSelected = "greed";
        }
        else if (gameObject.name.Contains("Gluttony"))
        {
            gluttony.SetActive(true);
            selectCharacter.characterSelected = "gluttony";
        }
        else if (gameObject.name.Contains("Wrath"))
        {
            wrath.SetActive(true);
            selectCharacter.characterSelected = "wrath";
        }
        else if (gameObject.name.Contains("Sloth"))
        {
            sloth.SetActive(true);
            selectCharacter.characterSelected = "sloth";
        }
        else if (gameObject.name.Contains("Envy"))
        {
            envy.SetActive(true);
            selectCharacter.characterSelected = "envy";
        }
        else if (gameObject.name.Contains("Lust"))
        {
            lust.SetActive(true);
            selectCharacter.characterSelected = "lust";
        }
        else if (gameObject.name.Contains("Pride"))
        {
            pride.SetActive(true);
            selectCharacter.characterSelected = "pride";
        }
        else if (gameObject.name.Contains("wrath"))
        {
            wrath.SetActive(true);
            selectCharacter.characterSelected = "wrath";
        }




    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
