using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setChartToNinja : MonoBehaviour
{

    public GameObject ninja;


    // Start is called before the first frame update
    void Awake()
    {
        selectCharacter.characterSelected = "ninja";
        playerSwitcher.S.playerType = "ninja";

        ninja.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
