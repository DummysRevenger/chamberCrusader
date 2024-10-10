using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setCharToSoldier : MonoBehaviour
{

    public GameObject soldier;


    void Awake()
    {

        selectCharacter.characterSelected = "soldier";
        playerSwitcher.S.playerType = "soldier";

    }


    // Start is called before the first frame update
    void Start()
    {
        soldier.SetActive(true);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
