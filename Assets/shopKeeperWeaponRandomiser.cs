using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopKeeperWeaponRandomiser : MonoBehaviour
{
    public static shopKeeperWeaponRandomiser S;

    public string theWeapon;

    // Start is called before the first frame update
    void Start()
    {
        S = this;

        int randomChoice = Random.Range(0, 3);

        switch (randomChoice)
        {
            case 0:
                theWeapon = "cane";
                break;
            case 1:
                theWeapon = "scythe";
                break;
            case 2:
                theWeapon = "longSword";
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
