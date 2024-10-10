using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pyramidResetter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        pyramidTransition.stage3bool = false;

        pyramidTransition.stage4bool = false;

        pyramidTransition.stage5bool = false;

        pyramidTransition.stage5Begun = false;

    }

// Update is called once per frame
void Update()
    {
        
    }
}
