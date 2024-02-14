using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room20checker : MonoBehaviour
{
    public static room20checker S;
    public static bool room20Reached = false;
    public static bool bloodRoom20Reached = false;


    // Start is called before the first frame update
    void Start()
    {
        S = this;
    }


    public void dungeon20Reached()
    {
        room20Reached = true;

        Debug.Log("20 unlocked");
    }

    public void bloodZone20Reached()
    {
        bloodRoom20Reached = true;
    }
    
    
}


