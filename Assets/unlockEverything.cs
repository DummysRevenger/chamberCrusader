using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlockEverything : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        room20checker.room20Reached = true;

        room20checker.bloodRoom20Reached = true;
    }

    // Update is called once per frame
    void Update()
    {
        room20checker.room20Reached = true;

        room20checker.bloodRoom20Reached = true;

        room20checker.desertRoom20Reached = true;
    }
}
