using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSwitcher : MonoBehaviour
{

    public string playerType;

    public static playerSwitcher S;

    // Start is called before the first frame update
    void Awake()
    {
        


        if (selectCharacter.characterSelected != null)
        {
            playerType = selectCharacter.characterSelected;
        }

        

    }
    void Start()
    {
        S = this;

        
    }

    // Update is called once per frame
    void Update()
    {



        


        if (selectCharacter.characterSelected != null)
        {
            playerType = selectCharacter.characterSelected;
        }

        

    }
}
