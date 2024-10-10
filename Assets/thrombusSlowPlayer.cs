using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thrombusSlowPlayer : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SlowPlayer", 1f);



    }

    void SlowPlayer()
    {
        playerMovementSpeedStore.S.speed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
