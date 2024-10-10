using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setChartToBunny : MonoBehaviour
{
    public GameObject bunny;



    void Awake()
    {

        selectCharacter.characterSelected = "bunny";
        

        bunny.SetActive(true);

    }


    // Start is called before the first frame update
    void Start()
    {
        playerSwitcher.S.playerType = "bunny";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
