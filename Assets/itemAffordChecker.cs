using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemAffordChecker : MonoBehaviour
{

    public static bool canAffordMagnet;
    public static bool canAfford1000;
    public static bool canAfford1500;
    public static bool canAffordGrabber;



    public static bool magnetSelected = false;
    public static bool magazineSelected = false;
    public static bool vitalityPotionSelected = false;
    public static bool ragePotionSelected = false;
    public static bool speedPotionSelected = false;
    public static bool foesBaneSelected = false;
    public static bool grabberSelected = false;
    public static bool grindStoneSelected = false;


    private GameObject magnetCross;
    private GameObject magazineCross;
    private GameObject vitalityCross;
    private GameObject rageCross;
    private GameObject speedCross;
    private GameObject foesBaneCross;
    private GameObject grindStoneCross;

    public static int selectedItemsValue;

    // Start is called before the first frame update
    void Start()
    {

        magnetSelected = false;
    magazineSelected = false;
    vitalityPotionSelected = false;
    ragePotionSelected = false;
    speedPotionSelected = false;
    foesBaneSelected = false;
    grabberSelected = false;
    grindStoneSelected = false;
}

    // Update is called once per frame
    void Update()
    {
        

        if (coinCounterStore.coinNumber - selectedItemsValue < 100 || coinCounterStore.coinNumber < 100)
        {
            canAffordMagnet = false;
            canAfford1500 = false;
            canAfford1000 = false;
            canAffordGrabber = false;
        }
        else
        {
            canAffordMagnet = true;
            if (coinCounterStore.coinNumber - selectedItemsValue < 500 || coinCounterStore.coinNumber < 500)
            {
                canAfford1000 = false;
                canAfford1500 = false;
                canAffordGrabber = false;
            }
            else
            {
                canAffordGrabber = true;
                if (coinCounterStore.coinNumber - selectedItemsValue < 1000 || coinCounterStore.coinNumber < 1000)
                {
                    canAfford1000 = false;
                    canAfford1500 = false;
                }
                else
                {
                    canAfford1000 = true;
                    if (coinCounterStore.coinNumber - selectedItemsValue < 1500 || coinCounterStore.coinNumber < 1500)
                    {
                        canAfford1500 = false;
                    }
                    else
                    {
                        canAfford1500 = true;
                    }
                }
            }
        }
    }
}
