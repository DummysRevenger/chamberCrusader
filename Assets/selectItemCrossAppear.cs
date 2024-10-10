using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectItemCrossAppear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //1
        if (gameObject.name.Contains("magazineCross") && !itemAffordChecker.canAfford1000 && !selectedItemsStore.magazineSelected)
        {
            GetComponent<Image>().enabled = true;
        }
        else if (gameObject.name.Contains("magazineCross") && itemAffordChecker.canAfford1000 && !selectedItemsStore.magazineSelected)
        {
            GetComponent<Image>().enabled = false;
        }

        //2
        if (gameObject.name.Contains("rageCross") && !itemAffordChecker.canAfford1500 && !selectedItemsStore.ragePotionSelected)
        {
            GetComponent<Image>().enabled = true;
        }
        else if (gameObject.name.Contains("rageCross") && itemAffordChecker.canAfford1500 && !selectedItemsStore.ragePotionSelected)
        {
            GetComponent<Image>().enabled = false;
        }

        //3
        if (gameObject.name.Contains("foesbane") && !itemAffordChecker.canAfford1000 && !selectedItemsStore.foesBaneSelected)
        {
            GetComponent<Image>().enabled = true;
        }
        else if (gameObject.name.Contains("foesbane") && itemAffordChecker.canAfford1000 && !selectedItemsStore.foesBaneSelected)
        {
            GetComponent<Image>().enabled = false;
        }

        //4
        if (gameObject.name.Contains("speedCross") && !itemAffordChecker.canAfford1000 && !selectedItemsStore.speedPotionSelected)
        {
            GetComponent<Image>().enabled = true;
        }
        else if (gameObject.name.Contains("speedCross") && itemAffordChecker.canAfford1000 && !selectedItemsStore.speedPotionSelected)
        {
            GetComponent<Image>().enabled = false;
        }

        //5
        if (gameObject.name.Contains("grindStoneCross") && !itemAffordChecker.canAfford1000 && !selectedItemsStore.magazineSelected)
        {
            GetComponent<Image>().enabled = true;
        }
        else if (gameObject.name.Contains("grindStoneCross") && itemAffordChecker.canAfford1000 && !selectedItemsStore.magazineSelected)
        {
            GetComponent<Image>().enabled = false;
        }



        //6
        if (gameObject.name.Contains("grabberCross") && !itemAffordChecker.canAffordGrabber && !selectedItemsStore.grabberSelected)
        {
            GetComponent<Image>().enabled = true;
        }
        else if (gameObject.name.Contains("grabberCross") && itemAffordChecker.canAffordGrabber && !selectedItemsStore.grabberSelected)
        {
            GetComponent<Image>().enabled = false;
        }

        //7
        if (gameObject.name.Contains("vitalityCross") && !itemAffordChecker.canAfford1500 && !selectedItemsStore.vitalityPotionSelected)
        {
            GetComponent<Image>().enabled = true;
        }
        else if (gameObject.name.Contains("vitalityCross") && itemAffordChecker.canAfford1500 && !selectedItemsStore.vitalityPotionSelected)
        {
            GetComponent<Image>().enabled = false;
        }

        //8
        if (gameObject.name.Contains("magnetCross") && !itemAffordChecker.canAffordMagnet && !selectedItemsStore.magnetSelected)
        {
            GetComponent<Image>().enabled = true;
        }
        else if (gameObject.name.Contains("magnetCross") && itemAffordChecker.canAffordMagnet && !selectedItemsStore.magnetSelected)
        {
            GetComponent<Image>().enabled = false;
        }
    }
}
