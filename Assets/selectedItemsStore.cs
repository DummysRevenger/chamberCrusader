using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectedItemsStore : MonoBehaviour
{

    public static bool magnetSelected = false;
    public static bool magazineSelected = false;
    public static bool vitalityPotionSelected = false;
    public static bool ragePotionSelected = false;
    public static bool speedPotionSelected = false;
    public static bool foesBaneSelected = false;
    public static bool grabberSelected = false;
    public static bool grindStoneSelected = false;

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
        
    }
}
