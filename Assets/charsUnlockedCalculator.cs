using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charsUnlockedCalculator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if ninja, soldier and bunny 
        if (room30checker.bloodRoom30Reached && room30checker.room30Reached && blueBunnyUnlockStore.bunnyUnlocked)
        {
            statsStore.charactersUnlocked = 3;
        }
        // if soldier and bunny 
        else if (room30checker.bloodRoom30Reached && blueBunnyUnlockStore.bunnyUnlocked)
        {
            statsStore.charactersUnlocked = 2;
        }
        // if ninja and bunny 
        else if (room30checker.room30Reached && blueBunnyUnlockStore.bunnyUnlocked)
        {
            statsStore.charactersUnlocked = 2;
        }
        // if ninja and soldier 
        else if (room30checker.room30Reached && room30checker.bloodRoom30Reached)
        {
            statsStore.charactersUnlocked = 2;
        }
        // if bunny
        else if(blueBunnyUnlockStore.bunnyUnlocked)
        {
            statsStore.charactersUnlocked = 1;
        }
        else if(room30checker.room30Reached)
        {
            statsStore.charactersUnlocked = 1;
        }
        else if(room30checker.bloodRoom30Reached)
        {
            statsStore.charactersUnlocked = 1;
        }
        else
        {
            statsStore.charactersUnlocked = 0;
        }


            
    }
}
