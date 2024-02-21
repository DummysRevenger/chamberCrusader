using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cleanSlate : MonoBehaviour
{

    void Awake()
    {

        

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        room20checker.bloodRoom20Reached = false;

        room30checker.bloodRoom30Reached = false;

        room20checker.room20Reached = false;

        room30checker.room30Reached = false;

        room10Skipper.room10reached = false;

        blueBunnyUnlockStore.bunnyUnlocked = false;

    }
}
