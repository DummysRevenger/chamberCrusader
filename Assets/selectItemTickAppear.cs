using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectItemTickAppear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Select()
    {

        Debug.Log(gameObject.name + " selected");

        switch(gameObject.name)
        {
            case "magnetTick":

                    if (selectedItemsStore.magnetSelected)
                    {
                        GetComponent<Image>().enabled = false;
                        selectedItemsStore.magnetSelected = false;

                        coinCounterStore.coinNumber += 100;
                    }
                    else if (!selectedItemsStore.magnetSelected && itemAffordChecker.canAffordMagnet)
                    {
                        GetComponent<Image>().enabled = true;
                        selectedItemsStore.magnetSelected = true;

                        coinCounterStore.coinNumber -= 100;
                    }
                
                break;
            case "magazineTick":


                

                    if (selectedItemsStore.magazineSelected)
                    {
                        coinCounterStore.coinNumber += 1000;

                        GetComponent<Image>().enabled = false;
                        selectedItemsStore.magazineSelected = false;
                    }
                    else if (!selectedItemsStore.magazineSelected && itemAffordChecker.canAfford1000)
                    {

                        coinCounterStore.coinNumber -= 1000;

                        GetComponent<Image>().enabled = true;
                        selectedItemsStore.magazineSelected = true;
                    }
                
                break;
            case "vitalityTick":

                    if (selectedItemsStore.vitalityPotionSelected)
                    {
                    coinCounterStore.coinNumber += 1500;

                    GetComponent<Image>().enabled = false;
                    selectedItemsStore.vitalityPotionSelected = false;
                    }
                    else if (!selectedItemsStore.vitalityPotionSelected && itemAffordChecker.canAfford1500)
                    {
                    coinCounterStore.coinNumber -= 1500;


                    GetComponent<Image>().enabled = true;
                    selectedItemsStore.vitalityPotionSelected = true;
                    }
                
                break;
            case "rageTick":
                
                
                    if (selectedItemsStore.ragePotionSelected)
                    {


                        coinCounterStore.coinNumber += 1500;

                        GetComponent<Image>().enabled = false;
                        selectedItemsStore.ragePotionSelected = false;
                    }
                    else if (itemAffordChecker.canAfford1500 && !selectedItemsStore.ragePotionSelected)
                    {

                        coinCounterStore.coinNumber -= 1500;


                        GetComponent<Image>().enabled = true;
                        selectedItemsStore.ragePotionSelected = true;
                    }
                
                break;
            case "speedTick":
                    if (selectedItemsStore.speedPotionSelected)
                    {
                        coinCounterStore.coinNumber += 1000;
                        GetComponent<Image>().enabled = false;
                        selectedItemsStore.speedPotionSelected = false;
                    }
                    else if (itemAffordChecker.canAfford1000 && !selectedItemsStore.speedPotionSelected)
                    {
                        coinCounterStore.coinNumber -= 1000;
                        GetComponent<Image>().enabled = true;
                        selectedItemsStore.speedPotionSelected = true;
                    }
                
                break;
            case "grabberTick":
                    if (selectedItemsStore.grabberSelected)
                    {
                        coinCounterStore.coinNumber += 500;
                        GetComponent<Image>().enabled = false;
                        selectedItemsStore.grabberSelected = false;
                    }
                    else if (itemAffordChecker.canAffordGrabber && !selectedItemsStore.grabberSelected)
                    {
                        coinCounterStore.coinNumber -= 500;
                        GetComponent<Image>().enabled = true;
                        selectedItemsStore.grabberSelected = true;
                    }
                
                break;
            case "grindStoneTick":
                if (itemAffordChecker.canAfford1000)
                {
                    if (selectedItemsStore.grindStoneSelected )
                    {
                        GetComponent<Image>().enabled = false;
                    }
                    else
                    {
                        GetComponent<Image>().enabled = true;
                    }
                }
                break;
            case "foesBaneTick":
                
                
                    if (selectedItemsStore.foesBaneSelected)
                    {

                        coinCounterStore.coinNumber += 1000;
                        GetComponent<Image>().enabled = false;
                        selectedItemsStore.foesBaneSelected = false;
                    }
                    else if (itemAffordChecker.canAfford1000 && !selectedItemsStore.foesBaneSelected)
                    {

                        coinCounterStore.coinNumber -= 1000;
                        GetComponent<Image>().enabled = true;
                        selectedItemsStore.foesBaneSelected = true;
                    }
                
                break;

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
