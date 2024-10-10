using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setCharToKnight : MonoBehaviour
{
    void Awake()
    {

        selectCharacter.characterSelected = "knight";
        selectCharacter.mapSelected = "dungeon";
        playerSwitcher.S.playerType = "knight";
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
