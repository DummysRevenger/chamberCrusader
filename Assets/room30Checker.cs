using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room30checker : MonoBehaviour
{
    public static room30checker S;
    public static bool room30Reached = false;
    public static bool bloodRoom30Reached = false;

    // Start is called before the first frame update
    void Start()
    {
        S = this;

        
}


    public void dungeon30Reached()
    {
        room30Reached = true;
    }


    public void bloodZone30Reached()
    {
        bloodRoom30Reached = true;
    }




}
