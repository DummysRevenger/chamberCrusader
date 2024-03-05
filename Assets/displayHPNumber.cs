using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayHPNumber : MonoBehaviour
{

    public hpStore target;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void setTarget(hpStore ooi)
    {
        target = ooi;
    }


    // Update is called once per frame
    void Update()
    {

        Text hpText = GetComponent<Text>();

        if (gameObject.name.Contains("player"))
        {
            hpText.text = (int)hpStorePlayer.S.playerHealth + "/" + hpStorePlayer.S.maxHealth;
        }
        else
        {
            hpText.text = (int)target.health + "/" + target.maxHealth;
        }
    }
}
