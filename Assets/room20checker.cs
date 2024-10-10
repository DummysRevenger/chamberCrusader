using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room20checker : MonoBehaviour
{
    public static room20checker S;
    public static bool room20Reached = false;
    public static bool bloodRoom20Reached = false;
    public static bool desertRoom20Reached = false;


    // Start is called before the first frame update
    void Start()
    {
        S = this;
    }


    public void dungeon20Reached()
    {
        room20Reached = true;

        
    }

    public void bloodZone20Reached()
    {
        bloodRoom20Reached = true;
    }

    public void desert20Reached()
    {
        desertRoom20Reached = true;
    }
    
    
}


