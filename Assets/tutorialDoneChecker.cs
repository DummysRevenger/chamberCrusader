using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialDoneChecker : MonoBehaviour
{

    public static tutorialDoneChecker S;

    public bool tutorialDone = false;

    // Start is called before the first frame update
    void Start()
    {
        S = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
