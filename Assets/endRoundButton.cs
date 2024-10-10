using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endRoundButton : MonoBehaviour
{
    public GameObject endRoundConfirm;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void endRound()
    {

        endRoundConfirm.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
