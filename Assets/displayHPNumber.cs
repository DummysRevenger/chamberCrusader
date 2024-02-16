using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayHPNumber : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Text hpText = GetComponent<Text>();

        hpText.text = (int)hpStorePlayer.S.playerHealth + "/" + hpStorePlayer.S.maxHealth;
    }
}
