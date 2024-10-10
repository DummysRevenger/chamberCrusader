using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomEventDecider : MonoBehaviour
{

    public GameObject cards;

    public GameObject coin;

    public GameObject dicex3;

    public GameObject dice;

    public GameObject wishBone;

    // Start is called before the first frame update
    void Start()
    {
        switch(selectCharacter.mapSelected)
        {
            case "dungeon":
                dice.SetActive(true);
                break;
            case "blood":
                wishBone.SetActive(true);
                break;
            case "desert":
                cards.SetActive(true);
                break;
            case "onion":
                coin.SetActive(true);
                break;
            case "retribution":
                dicex3.SetActive(true);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
