using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialDoneChecker : MonoBehaviour
{

    public static tutorialDoneChecker S;

    public static bool tutorialDone = false;

    // Start is called before the first frame update
    void Start()
    {
        S = this;

        tutorialDone = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
