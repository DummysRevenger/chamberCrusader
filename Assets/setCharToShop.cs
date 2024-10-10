using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setChartToShop : MonoBehaviour
{
    public GameObject shopKeep;



    void Awake()
    {
        selectCharacter.characterSelected = "shop";

        shopKeep.SetActive(true);

    }


    // Start is called before the first frame update
    void Start()
    {
        playerSwitcher.S.playerType = "shop";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
